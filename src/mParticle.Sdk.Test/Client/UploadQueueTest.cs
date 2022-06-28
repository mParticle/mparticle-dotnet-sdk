using System;
using mParticle.Api;
using mParticle.Model;
using mParticle.Client;
using System.Threading.Tasks;
using Xunit;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace mParticle.Client
{
    public class UploadQueueTest
    {

        [Fact]
        public void TestBatchEventMaxLimit()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"));
            var eventQueue = new UploadQueue((IMParticle)mParticle);
            for (int i = 0; i < 200; i++)
            {
                var e = new CustomEvent(i + "");
                eventQueue.AddEvent(e);
            }
            eventQueue.ForceUpload(false);
            Assert.Single(mParticle._uploadedBatches);
            Assert.Equal(100, mParticle._uploadedBatches[0].Events.Count);

            List<object> a = new List<object>();
            a.Add(1);
        }

        [Fact]
        public void UploadsEventsInOrder()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"));
            var eventQueue = new UploadQueue((IMParticle)mParticle);
            for (int i = 1; i < 201; i++)
            {
                var e = new CustomEvent(i + "");
                eventQueue.AddEvent(e);
            }
            eventQueue.ForceUpload(false);
            Assert.Single(mParticle._uploadedBatches);
            Assert.Equal(100, mParticle._uploadedBatches[0].Events.Count);
            foreach (BaseEvent e in mParticle._uploadedBatches[0].Events)
            {
                var eventNameNum = Int32.Parse(((CustomEvent)e).EventName);
                Assert.True(eventNameNum <= 100 && eventNameNum > 0);
            }
        }

        [Fact]
        public async Task UploadAsyncWithAwait()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"));
            var eventQueue = new UploadQueue((IMParticle)mParticle);
            
            eventQueue.AddEvent(new CustomEvent("0"));
       
            await eventQueue.ForceUploadAsync(false);
            Assert.Single(mParticle._uploadedBatches);
            Assert.Single(mParticle._uploadedBatches[0].Events);
            
            var e = mParticle._uploadedBatches[0].Events[0];
            Assert.Equal("0", ((CustomEvent)e).EventName);
           
        }

        [Fact]
        public void UploadAsyncWithoutAwait()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"));
            var eventQueue = new UploadQueue((IMParticle)mParticle);

            eventQueue.AddEvent(new CustomEvent("0"));

            eventQueue.ForceUploadAsync(false);

            //since we did not await, the network request should not have complete yet
            Assert.Empty(mParticle._uploadedBatches);
        }

        [Fact]
        public async void TestRateLimiting()
        {
            var headers = new Multimap<string, string>();
            headers.Add("Retry-After", "600");
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"), HttpStatusCode.TooManyRequests, headers);
            var eventQueue = new UploadQueue((IMParticle)mParticle);

            Assert.Empty(eventQueue._events);

            eventQueue.AddEvent(new CustomEvent("0"));

            // Confirm the event is in the queue
            Assert.Single(eventQueue._events);
            // Confirm the retry timestamp is before now
            Assert.True(eventQueue._retryAfterTimestamp < DateTime.Now);

            await eventQueue.ForceUploadAsync(false);

            // Confirm the event is still in the queue
            Assert.Single(eventQueue._events);
            // Confirm that the retry timestamp was set to the content of Retry-After header
            Assert.True(eventQueue._retryAfterTimestamp > DateTime.Now);
        }

        [Fact]
        public async void TestRateLimitingMissingHeader()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"), HttpStatusCode.TooManyRequests);
            var eventQueue = new UploadQueue((IMParticle)mParticle);

            Assert.Empty(eventQueue._events);

            eventQueue.AddEvent(new CustomEvent("0"));

            // Confirm the event is in the queue
            Assert.Single(eventQueue._events);
            // Confirm the retry timestamp is before now
            var retryAfterTimestamp = eventQueue._retryAfterTimestamp;
            Assert.True(retryAfterTimestamp < DateTime.Now);

            await eventQueue.ForceUploadAsync(false);

            // Confirm the event is still in the queue
            Assert.Single(eventQueue._events);
            // Confirm that the retry timestamp was not changed
            Assert.Equal(eventQueue._retryAfterTimestamp, retryAfterTimestamp);
        }

        [Fact]
        public async void TestRateLimitingBadHeaderValue()
        {
            var headers = new Multimap<string, string>();
            headers.Add("Retry-After", "sdkfjsdklf");
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"), HttpStatusCode.TooManyRequests, headers);
            var eventQueue = new UploadQueue((IMParticle)mParticle);

            Assert.Empty(eventQueue._events);

            eventQueue.AddEvent(new CustomEvent("0"));

            // Confirm the event is in the queue
            Assert.Single(eventQueue._events);
            // Confirm the retry timestamp is before now
            var retryAfterTimestamp = eventQueue._retryAfterTimestamp;
            Assert.True(retryAfterTimestamp < DateTime.Now);

            await eventQueue.ForceUploadAsync(false);

            // Confirm the event is still in the queue
            Assert.Single(eventQueue._events);
            // Confirm that the retry timestamp was not changed
            Assert.Equal(eventQueue._retryAfterTimestamp, retryAfterTimestamp);
        }
    }
    
    internal class MockMParticle : IMParticle
    {
        internal MockMParticle(Configuration configuration, HttpStatusCode statusCode = HttpStatusCode.Accepted, Multimap<string, string> headers = null)
        {
            Configuration = configuration;
            _statusCode = statusCode;
            _headers = headers == null ? new Multimap<string, string>() : headers;
        }
        internal List<Batch> _uploadedBatches = new List<Batch>();
        internal HttpStatusCode _statusCode;
        internal Multimap<string, string> _headers;

        public BaseBatch BaseBatch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IReadableConfiguration Configuration { get; set; }

        ApiResponse<object> BulkUploadBatches(Collection<Batch> batches)
        {
            foreach (Batch batch in batches)
            {
                _uploadedBatches.Add(batch);
            }
            return new ApiResponse<object>(_statusCode, _headers, new object(), "");
        }

        Task<ApiResponse<object>> BulkUploadBatchesAsync(Collection<Batch> batches)
        {
            foreach (Batch batch in batches)
            {
                _uploadedBatches.Add(batch);
            }
            return Task.Run(() => new ApiResponse<object>(_statusCode, _headers, new object(), ""));
        }

        public ApiResponse<object> UploadBatch(Batch batch)
        {
            _uploadedBatches.Add(batch);
            return new ApiResponse<object>(_statusCode, _headers, new object(), "");
        }

        async public Task<ApiResponse<object>> UploadBatchAsync(Batch batch)
        {
            await Task.Run(() => Thread.Sleep(5));
            _uploadedBatches.Add(batch);
            return new ApiResponse<object>(_statusCode, _headers, new object(), "");
        }

        public void LogEvent(BaseEvent baseEvent)
        {
            throw new NotImplementedException();
        }

        public void Upload()
        {
            throw new NotImplementedException();
        }

        public Task UploadAsync()
        {
            throw new NotImplementedException();
        }

        ApiResponse<object> IMParticle.BulkUploadBatches(Collection<Batch> batch)
        {
            throw new NotImplementedException();
        }

        Task<ApiResponse<object>> IMParticle.BulkUploadBatchesAsync(Collection<Batch> batch)
        {
            throw new NotImplementedException();
        }
    }
}
