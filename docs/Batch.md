# mParticle.Model.Batch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceRequestId** | **string** |  | [optional] 
**Context** | [**BatchContext**](BatchContext.md) |  | [optional] 
**Events** | [**Collection&lt;BaseEvent&gt;**](BaseEvent.md) | Provide a list of event objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent | [optional] 
**DeviceInfo** | [**DeviceInformation**](DeviceInformation.md) |  | [optional] 
**ApplicationInfo** | [**ApplicationInformation**](ApplicationInformation.md) |  | [optional] 
**UserAttributes** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**DeletedUserAttributes** | **Collection&lt;string&gt;** |  | [optional] 
**UserIdentities** | [**BatchUserIdentities**](BatchUserIdentities.md) |  | [optional] 
**Environment** | **string** |  | [default to EnvironmentEnum.Production]
**ApiKey** | **string** |  | [optional] 
**ApiKeys** | **Collection&lt;string&gt;** |  | [optional] 
**Ip** | **string** |  | [optional] 
**IntegrationAttributes** | **Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;** |  | [optional] 
**PartnerIdentity** | **string** |  | [optional] 
**SourceInfo** | [**SourceInformation**](SourceInformation.md) |  | [optional] 
**MpDeviceid** | **string** |  | [optional] 
**AttributionInfo** | [**AttributionInfo**](AttributionInfo.md) |  | [optional] 
**TimestampUnixtimeMs** | **long** |  | [optional] 
**BatchId** | **long** |  | [optional] 
**Mpid** | **long** |  | [optional] 
**SdkVersion** | **string** |  | [optional] 
**ConsentState** | [**ConsentState**](ConsentState.md) |  | [optional] 
**JobId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

