using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mParticle.Sdk.Client.OpenAPIDateConverter;

namespace mParticle.Sdk.Model
{
    /// <summary>
    /// Batch
    /// </summary>
    [DataContract]
    public partial class Batch :  IEquatable<Batch>, IValidatableObject
    {
        /// <summary>
        /// Defines Environment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Development for value: development
            /// </summary>
            [EnumMember(Value = "development")]
            Development = 2,

            /// <summary>
            /// Enum Production for value: production
            /// </summary>
            [EnumMember(Value = "production")]
            Production = 3

        }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public EnvironmentEnum Environment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Batch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="sourceRequestId">sourceRequestId.</param>
        /// <param name="context">context.</param>
        /// <param name="events">Provide a list of event objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent.</param>
        /// <param name="deviceInfo">deviceInfo.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="userAttributes">userAttributes.</param>
        /// <param name="deletedUserAttributes">deletedUserAttributes.</param>
        /// <param name="userIdentities">userIdentities.</param>
        /// <param name="environment">environment (required) (default to EnvironmentEnum.Production).</param>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="apiKeys">apiKeys.</param>
        /// <param name="ip">ip.</param>
        /// <param name="integrationAttributes">integrationAttributes.</param>
        /// <param name="partnerIdentity">partnerIdentity.</param>
        /// <param name="sourceInfo">sourceInfo.</param>
        /// <param name="mpDeviceid">mpDeviceid.</param>
        /// <param name="attributionInfo">attributionInfo.</param>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs.</param>
        /// <param name="batchId">batchId.</param>
        /// <param name="mpid">mpid.</param>
        /// <param name="sdkVersion">sdkVersion.</param>
        /// <param name="consentState">consentState.</param>
        /// <param name="jobId">jobId.</param>
        public Batch(string sourceRequestId = default(string), BatchContext context = default(BatchContext), Collection<BaseEvent> events = default(Collection<BaseEvent>), DeviceInformation deviceInfo = default(DeviceInformation), ApplicationInformation applicationInfo = default(ApplicationInformation), Dictionary<string, Object> userAttributes = default(Dictionary<string, Object>), Collection<string> deletedUserAttributes = default(Collection<string>), BatchUserIdentities userIdentities = default(BatchUserIdentities), EnvironmentEnum environment = EnvironmentEnum.Production, string apiKey = default(string), Collection<string> apiKeys = default(Collection<string>), string ip = default(string), Dictionary<string, Dictionary<string, string>> integrationAttributes = default(Dictionary<string, Dictionary<string, string>>), string partnerIdentity = default(string), SourceInformation sourceInfo = default(SourceInformation), string mpDeviceid = default(string), AttributionInfo attributionInfo = default(AttributionInfo), long timestampUnixtimeMs = default(long), long batchId = default(long), long mpid = default(long), string sdkVersion = default(string), ConsentState consentState = default(ConsentState), string jobId = default(string))
        {
            this.Environment = environment;
            this.SourceRequestId = sourceRequestId;
            this.Context = context;
            this.Events = events;
            this.DeviceInfo = deviceInfo;
            this.ApplicationInfo = applicationInfo;
            this.UserAttributes = userAttributes;
            this.DeletedUserAttributes = deletedUserAttributes;
            this.UserIdentities = userIdentities;
            this.ApiKey = apiKey;
            this.ApiKeys = apiKeys;
            this.Ip = ip;
            this.IntegrationAttributes = integrationAttributes;
            this.PartnerIdentity = partnerIdentity;
            this.SourceInfo = sourceInfo;
            this.MpDeviceid = mpDeviceid;
            this.AttributionInfo = attributionInfo;
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            this.BatchId = batchId;
            this.Mpid = mpid;
            this.SdkVersion = sdkVersion;
            this.ConsentState = consentState;
            this.JobId = jobId;
        }
        
        /// <summary>
        /// Gets or Sets SourceRequestId
        /// </summary>
        [DataMember(Name="source_request_id", EmitDefaultValue=false)]
        public string SourceRequestId { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public BatchContext Context { get; set; }

        /// <summary>
        /// Provide a list of event objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent
        /// </summary>
        /// <value>Provide a list of event objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public Collection<BaseEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInfo
        /// </summary>
        [DataMember(Name="device_info", EmitDefaultValue=false)]
        public DeviceInformation DeviceInfo { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInfo
        /// </summary>
        [DataMember(Name="application_info", EmitDefaultValue=false)]
        public ApplicationInformation ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets UserAttributes
        /// </summary>
        [DataMember(Name="user_attributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> UserAttributes { get; set; }

        /// <summary>
        /// Gets or Sets DeletedUserAttributes
        /// </summary>
        [DataMember(Name="deleted_user_attributes", EmitDefaultValue=false)]
        public Collection<string> DeletedUserAttributes { get; set; }

        /// <summary>
        /// Gets or Sets UserIdentities
        /// </summary>
        [DataMember(Name="user_identities", EmitDefaultValue=false)]
        public BatchUserIdentities UserIdentities { get; set; }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="api_key", EmitDefaultValue=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets ApiKeys
        /// </summary>
        [DataMember(Name="api_keys", EmitDefaultValue=false)]
        public Collection<string> ApiKeys { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationAttributes
        /// </summary>
        [DataMember(Name="integration_attributes", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> IntegrationAttributes { get; set; }

        /// <summary>
        /// Gets or Sets PartnerIdentity
        /// </summary>
        [DataMember(Name="partner_identity", EmitDefaultValue=false)]
        public string PartnerIdentity { get; set; }

        /// <summary>
        /// Gets or Sets SourceInfo
        /// </summary>
        [DataMember(Name="source_info", EmitDefaultValue=false)]
        public SourceInformation SourceInfo { get; set; }

        /// <summary>
        /// Gets or Sets MpDeviceid
        /// </summary>
        [DataMember(Name="mp_deviceid", EmitDefaultValue=false)]
        public string MpDeviceid { get; set; }

        /// <summary>
        /// Gets or Sets AttributionInfo
        /// </summary>
        [DataMember(Name="attribution_info", EmitDefaultValue=false)]
        public AttributionInfo AttributionInfo { get; set; }

        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public long TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name="batch_id", EmitDefaultValue=false)]
        public long BatchId { get; set; }

        /// <summary>
        /// Gets or Sets Mpid
        /// </summary>
        [DataMember(Name="mpid", EmitDefaultValue=false)]
        public long Mpid { get; set; }

        /// <summary>
        /// Gets or Sets SdkVersion
        /// </summary>
        [DataMember(Name="sdk_version", EmitDefaultValue=false)]
        public string SdkVersion { get; set; }

        /// <summary>
        /// Gets or Sets ConsentState
        /// </summary>
        [DataMember(Name="consent_state", EmitDefaultValue=false)]
        public ConsentState ConsentState { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Batch {\n");
            sb.Append("  SourceRequestId: ").Append(SourceRequestId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  DeviceInfo: ").Append(DeviceInfo).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  UserAttributes: ").Append(UserAttributes).Append("\n");
            sb.Append("  DeletedUserAttributes: ").Append(DeletedUserAttributes).Append("\n");
            sb.Append("  UserIdentities: ").Append(UserIdentities).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ApiKeys: ").Append(ApiKeys).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  IntegrationAttributes: ").Append(IntegrationAttributes).Append("\n");
            sb.Append("  PartnerIdentity: ").Append(PartnerIdentity).Append("\n");
            sb.Append("  SourceInfo: ").Append(SourceInfo).Append("\n");
            sb.Append("  MpDeviceid: ").Append(MpDeviceid).Append("\n");
            sb.Append("  AttributionInfo: ").Append(AttributionInfo).Append("\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Mpid: ").Append(Mpid).Append("\n");
            sb.Append("  SdkVersion: ").Append(SdkVersion).Append("\n");
            sb.Append("  ConsentState: ").Append(ConsentState).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Batch);
        }

        /// <summary>
        /// Returns true if Batch instances are equal
        /// </summary>
        /// <param name="input">Instance of Batch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Batch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceRequestId == input.SourceRequestId ||
                    (this.SourceRequestId != null &&
                    this.SourceRequestId.Equals(input.SourceRequestId))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.DeviceInfo == input.DeviceInfo ||
                    (this.DeviceInfo != null &&
                    this.DeviceInfo.Equals(input.DeviceInfo))
                ) && 
                (
                    this.ApplicationInfo == input.ApplicationInfo ||
                    (this.ApplicationInfo != null &&
                    this.ApplicationInfo.Equals(input.ApplicationInfo))
                ) && 
                (
                    this.UserAttributes == input.UserAttributes ||
                    this.UserAttributes != null &&
                    input.UserAttributes != null &&
                    this.UserAttributes.SequenceEqual(input.UserAttributes)
                ) && 
                (
                    this.DeletedUserAttributes == input.DeletedUserAttributes ||
                    this.DeletedUserAttributes != null &&
                    input.DeletedUserAttributes != null &&
                    this.DeletedUserAttributes.SequenceEqual(input.DeletedUserAttributes)
                ) && 
                (
                    this.UserIdentities == input.UserIdentities ||
                    (this.UserIdentities != null &&
                    this.UserIdentities.Equals(input.UserIdentities))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.ApiKeys == input.ApiKeys ||
                    this.ApiKeys != null &&
                    input.ApiKeys != null &&
                    this.ApiKeys.SequenceEqual(input.ApiKeys)
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.IntegrationAttributes == input.IntegrationAttributes ||
                    this.IntegrationAttributes != null &&
                    input.IntegrationAttributes != null &&
                    this.IntegrationAttributes.SequenceEqual(input.IntegrationAttributes)
                ) && 
                (
                    this.PartnerIdentity == input.PartnerIdentity ||
                    (this.PartnerIdentity != null &&
                    this.PartnerIdentity.Equals(input.PartnerIdentity))
                ) && 
                (
                    this.SourceInfo == input.SourceInfo ||
                    (this.SourceInfo != null &&
                    this.SourceInfo.Equals(input.SourceInfo))
                ) && 
                (
                    this.MpDeviceid == input.MpDeviceid ||
                    (this.MpDeviceid != null &&
                    this.MpDeviceid.Equals(input.MpDeviceid))
                ) && 
                (
                    this.AttributionInfo == input.AttributionInfo ||
                    (this.AttributionInfo != null &&
                    this.AttributionInfo.Equals(input.AttributionInfo))
                ) && 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    this.BatchId.Equals(input.BatchId)
                ) && 
                (
                    this.Mpid == input.Mpid ||
                    this.Mpid.Equals(input.Mpid)
                ) && 
                (
                    this.SdkVersion == input.SdkVersion ||
                    (this.SdkVersion != null &&
                    this.SdkVersion.Equals(input.SdkVersion))
                ) && 
                (
                    this.ConsentState == input.ConsentState ||
                    (this.ConsentState != null &&
                    this.ConsentState.Equals(input.ConsentState))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SourceRequestId != null)
                    hashCode = hashCode * 59 + this.SourceRequestId.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.DeviceInfo != null)
                    hashCode = hashCode * 59 + this.DeviceInfo.GetHashCode();
                if (this.ApplicationInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationInfo.GetHashCode();
                if (this.UserAttributes != null)
                    hashCode = hashCode * 59 + this.UserAttributes.GetHashCode();
                if (this.DeletedUserAttributes != null)
                    hashCode = hashCode * 59 + this.DeletedUserAttributes.GetHashCode();
                if (this.UserIdentities != null)
                    hashCode = hashCode * 59 + this.UserIdentities.GetHashCode();
                hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ApiKey != null)
                    hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.ApiKeys != null)
                    hashCode = hashCode * 59 + this.ApiKeys.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.IntegrationAttributes != null)
                    hashCode = hashCode * 59 + this.IntegrationAttributes.GetHashCode();
                if (this.PartnerIdentity != null)
                    hashCode = hashCode * 59 + this.PartnerIdentity.GetHashCode();
                if (this.SourceInfo != null)
                    hashCode = hashCode * 59 + this.SourceInfo.GetHashCode();
                if (this.MpDeviceid != null)
                    hashCode = hashCode * 59 + this.MpDeviceid.GetHashCode();
                if (this.AttributionInfo != null)
                    hashCode = hashCode * 59 + this.AttributionInfo.GetHashCode();
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                hashCode = hashCode * 59 + this.Mpid.GetHashCode();
                if (this.SdkVersion != null)
                    hashCode = hashCode * 59 + this.SdkVersion.GetHashCode();
                if (this.ConsentState != null)
                    hashCode = hashCode * 59 + this.ConsentState.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
