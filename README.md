<img src="https://static.mparticle.com/sdk/mp_logo_black.svg" width="280">

## Dotnet Server Events SDK

This is the mParticle Dotnet SDK for the server-based Events API - use it to send your data to the [mParticle platform](https://www.mparticle.com/) and off to 250+ integrations! The SDK is designed to be use in a variety of environments. It provides a [Retrofit](https://square.github.io/retrofit/) interface as well as serializable models if you prefer to handle HTTP transport on your own.


### Requirements.

Dotnet 2.0 and later

## Getting Started 

### Add the Dependency

The SDK is available via NuGet.

```
Install-Package mParticle.Sdk [-Version <VERSION>]
```

## Create a `Batch`

All data that passes through mParticle does so in the form of a "batch." A batch describes identities, attributes, events, and other information related to a *single user*. This SDK lets you upload either single batches or multiple batches at a time.

The full schema of a batch is documented in the [mParticle Events API overview](https://docs.mparticle.com/developers/server/http/). The models in this SDK directly match the JSON referenced in the overview.

```csharp
Batch batch = new Batch();
batch.Environment = BaseBatch.EnvironmentEnum.Development;

// Set user identities
batch.UserIdentities = new BatchUserIdentities() 
{
        CustomerId = "1234",
        Email = "example@foo.com"
};
                


// Set device identities
batch.DeviceInfo = new DeviceInformation() 
{
        IosAdvertisingId = "5864e6b0-0d46-4667-a463-21d9493b6c10"
};            

// Set user attributes
var userAttributes = new Dictionary<string, object>();
userAttributes["foo"] = "bar";
userAttributes["foo-array"] = new String[]{"bar1", "bar2"};
userAttributes["foo-array-2"] = new List<string>() {{"bar3"},{"bar4"}};
batch.UserAttributes = userAttributes;
```

> It's critical to include either user or device identities with your server-side data

## Create Events

All mParticle events have a similar structure:

- `event_type`: this is the type of event, such as `custom_event` and `commerce_event`
- `data`: this contains common properties of all events, as well as properties specific to each `event_type`

The following are common properties that all events share, as represented by the `CommonEventData` class:

```javascript
{
	"data" :
	{
		"event_id" : 6004677780660780000,
		"source_message_id" : "e8335d31-2031-4bff-afec-17ffc1784697",
		"session_id" : 4957918240501247982,
		"session_uuid" : "91b86d0c-86cb-4124-a8b2-edee107de454",
		"timestamp_unixtime_ms" : 1402521613976,
		"location" : {},
		"device_current_state" : {},
		"custom_attributes": {},
		"custom_flags": {}
	},
	"event_type" : "custom_event"
}

```

The Dotnet SDK represents this structure via an event and an event-data class for each unique event type. For example, `CustomEvent` which can be populated by a `CustomEventData` instance.

### Custom Events

```csharp
var customEvent = new CustomEvent("My Custom Event Name", CustomEvent.CustomEventTypeEnum.Location) 
{
    CustomAttributes = new Dictionary<string, string>()
    {
        { "foo", "bar" }
    } 
}  
```

### Screen Events

```csharp
var screenViewEvent = new ScreenViewEvent("foo screen");            
```

### Commerce Events

```csharp
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
```


## Full Upload Example

### Create an `EventsApi` instance

`EventsApi` is a Retrofit-compatible interface, allowing you to use the rich feature-set of the Retrofit and OkHttp libraries, such as queueing and asynchronous requests.

Create an API instance with your mParticle workspace credentials. These credentials may be either "platform" (iOS, Android, etc) or "custom feed" keys:

```csharp
MParticle.Start(new Configuration("API KEY", "API-SECRET"));
```

> The mParticle Events API leverages HTTP basic authentication over TLS. 

### LogEvents individually

The SDK supports event logging. In this case, we will handle the creation of a Batch, and upload the events on an interval defined by the defined Configuration#UploadInterval (default 60 seconds). You may register a BaseBatch to specify Batch properties that will be included in these uploads.

```csharp
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
```

### Perform a Synchronous Upload

The SDK supports both multi-batch ("bulk") or single-batch uploads:

```csharp
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
```

### Perform an Asynchronous Upload

The SDK also supports both async multi-batch ("bulk) or async single-batch uploads

```csharp
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
                //do something
        }
);
```

### License

[Apache License 2.0](http://www.apache.org/licenses/LICENSE-2.0)
