# mParticle.Api.EventsApi

All URIs are relative to *https://s2s.mparticle.com/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkUploadEvents**](EventsApi.md#bulkuploadevents) | **POST** /bulkevents | Send events to mParticle
[**UploadEvents**](EventsApi.md#uploadevents) | **POST** /events | Send events to mParticle


<a name="bulkuploadevents"></a>
# **BulkUploadEvents**
> void BulkUploadEvents (Collection<Batch> batch = null)

Send events to mParticle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mParticle.Api;
using mParticle.Client;
using mParticle.Model;

namespace Example
{
    public class BulkUploadEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://s2s.mparticle.com/v2";
            var apiInstance = new EventsApi(config);
            var batch = new Collection<Batch>(); // Collection<Batch> |  (optional) 

            try
            {
                // Send events to mParticle
                apiInstance.BulkUploadEvents(batch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.BulkUploadEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch** | [**Collection&lt;Batch&gt;**](Batch.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request - malformed JSON or required fields missing. |  -  |
| **401** | Unauthorized - authentication missing or invalid |  -  |
| **403** | Forbidden - API key/secret are present but not valid |  -  |
| **429** | Too many requests - rate limiting is being applied |  -  |
| **503** | Service unavailable - the message should be retried after a back off |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadevents"></a>
# **UploadEvents**
> void UploadEvents (Batch batch = null)

Send events to mParticle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mParticle.Api;
using mParticle.Client;
using mParticle.Model;

namespace Example
{
    public class UploadEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://s2s.mparticle.com/v2";
            var apiInstance = new EventsApi(config);
            var batch = new Batch(); // Batch |  (optional) 

            try
            {
                // Send events to mParticle
                apiInstance.UploadEvents(batch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UploadEvents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch** | [**Batch**](Batch.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request - malformed JSON or required fields missing. |  -  |
| **401** | Unauthorized - authentication missing or invalid |  -  |
| **403** | Forbidden - API key/secret are present but not valid |  -  |
| **429** | Too many requests - rate limiting is being applied |  -  |
| **503** | Service unavailable - the message should be retried after a back off |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

