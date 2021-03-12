using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using mParticle.Api;
using mParticle.Client;
using mParticle.Model;
using Xunit;

namespace mParticle.Test
{

    public class CodeSamples
    {
        
        public void General() 
        {
            Batch batch = new Batch();
            batch.Environment = BaseBatch.EnvironmentEnum.Development;

            // Set user identities
            batch.UserIdentities = new BatchUserIdentities() {
                        CustomerId = "1234",
                        Email = "example@foo.com"
                    };
                            
        

            // Set device identities
            batch.DeviceInfo = 
                    new DeviceInformation() {
                        IosAdvertisingId = "5864e6b0-0d46-4667-a463-21d9493b6c10",
                        AttTimestampUnixtimeMs = 1552679728376,
                        AttAuthorizationStatus = DeviceInformation.AttAuthorizationStatusEnum.Authorized
                    };            

            // Set user attributes
            var userAttributes = new Dictionary<string, object>();
            userAttributes["foo"] = "bar";
            userAttributes["foo-array"] = new String[]{"bar1", "bar2"};
            userAttributes["foo-array-2"] = new List<string>() {{"bar3"},{"bar4"}};
            batch.UserAttributes = userAttributes;
        }

        public void CustomEventSample() 
        {
            MParticle.Start(new Configuration("API KEY", "API-SECRET"));

            var customEvent = new CustomEvent("My Custom Event Name", CustomEvent.CustomEventTypeEnum.Location) 
                {
                        CustomAttributes = new Dictionary<string, string>()
                        {
                            { "foo", "bar" }
                        }
                };   
        }

        public void ScreenEvent() 
        {
            var screenViewEvent = new ScreenViewEvent("foo screen");            
        }

        public void CommerceEvents()
        {
            var product = new Product("product-id", "product-name") 
            {
                    TotalProductAmount = new Decimal(123.12),
            };
            var productAction = new ProductAction(ProductAction.ActionEnum.Purchase) 
            {       
                    TotalAmount = new Decimal(123.12),
                    TransactionId = "foo-transaction-id"
            };
            var commerceEvent = new CommerceEvent(productAction);
        }

        public void CreateApi()
        {
            MParticle.Start(new Configuration("API KEY", "API-SECRET"));
        }


        public void LogEvents()
        {
            // Assemble and register your BaseBatch
            var batch = new BaseBatch();
            batch.Environment = Batch.EnvironmentEnum.Development;
            batch.UserIdentities = new BatchUserIdentities() 
            {
                    CustomerId = "1234",
                    Email = "example@foo.com"
            };
            MParticle.Instance.BaseBatch = batch;

            // Create your events
            var customAttributes = new Dictionary<string, string>();
            customAttributes["foo"] = "bar";
            var customEvent = new CustomEvent("foo event", CustomEvent.CustomEventTypeEnum.Location);

            var screenEvent = new ScreenViewEvent("foo screen");

            // Log events
            MParticle.Instance.LogEvent(customEvent);
            MParticle.Instance.LogEvent(screenEvent);

            //(optional) Force an immediate upload (before the UploadInterval is finished, this will restart the UploadInterval)
            MParticle.Instance.Upload();
        }
        public void SyncBatchExmple()
        {
            // Assemble your Batch
            var batch = new Batch();
            batch.Environment = Batch.EnvironmentEnum.Development;
            batch.UserIdentities = new BatchUserIdentities() 
            {
                    CustomerId = "1234",
                    Email = "example@foo.com"
            };

            // Create your events and add to Batch
            var customAttributes = new Dictionary<string, string>();
            customAttributes["foo"] = "bar";
            var customEvent = new CustomEvent("foo event", CustomEvent.CustomEventTypeEnum.Location);
            batch.Events.Add(customEvent);

            var screenEvent = new ScreenViewEvent("foo screen");
            
            batch.Events.Add(screenEvent);

            // Either
            // 1) Perform a single upload
            var batchResult = MParticle.Instance.UploadBatch(batch);

            // 2) Perform a bulk upload
            var bulk = new Collection<Batch>();
            bulk.Add(batch);
            var bulkBatchResult = MParticle.Instance.BulkUploadBatches(bulk);
        }

        public void BatchAsync() {
            // Assemble your Batch
            var batch = new Batch();
            batch.Environment = Batch.EnvironmentEnum.Development;
            batch.UserIdentities = new BatchUserIdentities() 
            {
                    CustomerId = "1234",
                    Email = "example@foo.com"
            };

            // Create your events and add to Batch
            var customAttributes = new Dictionary<string, string>();
            customAttributes["foo"] = "bar";
            var customEvent = new CustomEvent("foo event", CustomEvent.CustomEventTypeEnum.Location);
            
            batch.Events.Add(customEvent);

            var screenEvent = new ScreenViewEvent("foo screen");

            batch.Events.Add(screenEvent);

            // Either
            // 1) Perform a single upload
            var batchResult = MParticle.Instance.UploadBatchAsync(batch)
                .ContinueWith(apiResonse =>
                    {
                        //do something
                    }
                );

            // 2) Perform a bulk upload
            var bulk = new Collection<Batch>();
            bulk.Add(batch);
            MParticle.Instance.BulkUploadBatchesAsync(bulk)
                .ContinueWith(apiResponse =>
                    {
                       //do some stuff
                    }
                );
        }

    }

}