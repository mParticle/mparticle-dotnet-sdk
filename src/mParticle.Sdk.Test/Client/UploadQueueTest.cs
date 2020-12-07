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
        public void testBatchEventMaxLimit()
        {
            var mParticle = new MockMParticle(new Configuration("apikey", "apiSecret"));
            var eventQueue = new UploadQueue((IMParticle)mParticle);
            for (int i = 0; i < 200; i++)
            {
                var e = new CustomEvent(i + "");
                eventQueue.AddEvent(e);
            }
            eventQueue.ForceUpload(false);
            Assert.Single(mParticle.uploadedBatches);
            Assert.Equal(100, mParticle.uploadedBatches[0].Events.Count);

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
            Assert.Single(mParticle.uploadedBatches);
            Assert.Equal(100, mParticle.uploadedBatches[0].Events.Count);
            foreach (BaseEvent e in mParticle.uploadedBatches[0].Events)
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
            Assert.Single(mParticle.uploadedBatches);
            Assert.Single(mParticle.uploadedBatches[0].Events);
            
            var e = mParticle.uploadedBatches[0].Events[0];
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
            Assert.Empty(mParticle.uploadedBatches);
        }
    }

    internal class MockMParticle : IMParticle
    {

        internal MockMParticle(Configuration configuration) {
            Configuration = configuration;
        }
        internal List<Batch> uploadedBatches = new List<Batch>();

        public BaseBatch BaseBatch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IReadableConfiguration Configuration { get; set; }

        ApiResponse<object> BulkUploadBatches(Collection<Batch> batches)
        {
            foreach (Batch batch in batches)
            {
                uploadedBatches.Add(batch);
            }
            return new ApiResponse<object>(HttpStatusCode.Accepted, new object(), "");
        }

        Task<ApiResponse<object>> BulkUploadBatchesAsync(Collection<Batch> batches)
        {
            foreach (Batch batch in batches)
            {
                uploadedBatches.Add(batch);
            }
            return Task.Run(() => new ApiResponse<object>(HttpStatusCode.Accepted, new object(), ""));
        }


        public ApiResponse<object> UploadBatch(Batch batch)
        {
            uploadedBatches.Add(batch);
            return new ApiResponse<object>(HttpStatusCode.Accepted, new object(), "");
        }

        async public Task<ApiResponse<object>> UploadBatchAsync(Batch batch)
        {
            await Task.Run(() => Thread.Sleep(5));
            uploadedBatches.Add(batch);
            return new ApiResponse<object>(HttpStatusCode.Accepted, new object(), "");
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
