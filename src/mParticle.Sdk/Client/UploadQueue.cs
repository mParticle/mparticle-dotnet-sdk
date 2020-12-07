using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using mParticle.Api;
using mParticle.Model;

namespace mParticle.Client
{
    internal class UploadQueue
    {
        private IMParticle _mParticle;
        private Batch _baseBatch = new Batch();
        private IReadableConfiguration _configuration;
        private List<BaseEventMessage> _events = new List<BaseEventMessage>();
        private Timer _timer;
        private object syncLock = new object();

        public UploadQueue(IMParticle mParticle)
        {
            _mParticle = mParticle;
            _configuration = mParticle.Configuration;
            Logger.Verbose("Starting upload loop " + DateTime.Now.Second);
        }

        public BaseBatch BaseBatch
        {
            get
            {
                return new BaseBatch(_baseBatch);
            }
            set 
            {
                if (value != null)
                {
                    _baseBatch = new Batch(value);
                }
                else
                {
                    _baseBatch = new Batch();
                }
            }
        }

        public void AddEvent(BaseEvent baseEvent)
        {
            lock (syncLock)
            {
                var baseEventMessage = new BaseEventMessage(baseEvent);
                _events.Add(baseEventMessage);
            }
            if (_timer == null || !_timer.Enabled)
            {
                StartUploadLoop();
            }
        }

        internal void RemoveEvents(List<BaseEventMessage> baseEvents)
        {
            lock (syncLock)
            {
                _events.RemoveCollection(baseEvents);
            }
        }

        public void ForceUpload(bool restartUploadLoop = true)
        {
            if (_timer != null)
            {
                _timer.Stop();
            }
            Upload(null, null).ConfigureAwait(false).GetAwaiter().GetResult();
            if (restartUploadLoop)
            {
                StartUploadLoop();
            }
        }

        public async Task ForceUploadAsync(bool restartUploadLoop = true)
        {
            if (_timer != null)
            {
                _timer.Stop();
            }
            await Upload(null, null);
            if (restartUploadLoop)
            {
                StartUploadLoop();
            }
        }

        public void StartUploadLoop()
        {
            ScheduleUpload();
        }

        void UploadLoop(object o, System.Timers.ElapsedEventArgs e)
        {
            Upload(o, e).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        async Task Upload(object _, System.Timers.ElapsedEventArgs __)
        {
            var baseEvents = new List<BaseEventMessage>(_events);
            if (baseEvents.Count > 0)
            {
                Logger.Verbose("Uploading " + baseEvents.Count + " events");
                var batch = new Batch(_baseBatch);
                var batchEvents = new List<BaseEventMessage>();
                for (var i = 0; batchEvents.Count < 100 && i < baseEvents.Count; i++)
                {
                    var e = baseEvents[i];
                    if (e != null && e.Status == Status.Ready)
                    {
                        e.Status = Status.InProgress;
                        batchEvents.Add(e);
                    }
                }
                foreach (BaseEventMessage baseEventMessage in batchEvents)
                {
                    batch.Events.Add(baseEventMessage.BaseEvent);
                }

                var result = await _mParticle.UploadBatchAsync(batch);
                //finish and dispose of 200s
                if ((int)result.StatusCode >= 200 && (int)result.StatusCode < 300)
                {
                    Logger.Verbose("Events uploaded successfully");
                    RemoveEvents(batchEvents);
                }
                //retry 429 and 500s
                else if ((int)result.StatusCode == 429 || (int)result.StatusCode >= 500)
                {
                    Logger.Warning("Unable to upload Events, these will be retried at next upload interval. \n\tResponse Code: " + result.ResponseType + "\n\tMessage: " + result.ErrorText);
                    batchEvents.ForEach(x => x.Status = Status.Ready);
                }
                //remove other 400s, can't be retried
                else if ((int)result.StatusCode >= 400 && (int)result.StatusCode < 500)
                {
                    Logger.Error("Error uploading Events:\n\tResponse Code: " + result.ResponseType + "\n\tMessage: " + result.ErrorText);
                    RemoveEvents(batchEvents);
                }
            }
            else
            {
                Logger.Verbose("Skipping Upload, no events");
            }
        }

        void ScheduleUpload()
        {
            Logger.Verbose("Starting timer for every " + _configuration.UploadInterval + "ms");
            _timer = new Timer()
            {
                Interval = _configuration.UploadInterval
            };
            _timer.Elapsed += UploadLoop;
            _timer.AutoReset = true;
            _timer.Start();
        }
    }

    internal class BaseEventMessage: IEquatable<BaseEventMessage>
    {
        internal Status Status;
        internal BaseEvent BaseEvent; 
        internal string Uuid;

        internal BaseEventMessage(BaseEvent baseEvent)
        {
            BaseEvent = baseEvent;
            Status = Client.Status.Ready;
            Uuid = Guid.NewGuid().ToString();
        }

        public bool Equals(BaseEventMessage input)
        {
            return Uuid.Equals(input.Uuid);
        }
    }

    internal enum Status
    {
        Ready,
        InProgress
    }
}
