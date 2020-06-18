using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// Batch
    /// </summary>
    [DataContract]
    public partial class Batch : BaseBatch
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Batch() {
            this.Events = new Collection<BaseEvent>();
        }

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
        public Batch(string sourceRequestId = default(string), BatchContext context = default(BatchContext), Collection<BaseEvent> events = default(Collection<BaseEvent>), DeviceInformation deviceInfo = default(DeviceInformation), ApplicationInformation applicationInfo = default(ApplicationInformation), Dictionary<string, Object> userAttributes = default(Dictionary<string, Object>), Collection<string> deletedUserAttributes = default(Collection<string>), BatchUserIdentities userIdentities = default(BatchUserIdentities), EnvironmentEnum environment = EnvironmentEnum.Production, string ip = default(string), Dictionary<string, Dictionary<string, string>> integrationAttributes = default(Dictionary<string, Dictionary<string, string>>), string partnerIdentity = default(string), SourceInformation sourceInfo = default(SourceInformation), string mpDeviceid = default(string), AttributionInfo attributionInfo = default(AttributionInfo), long timestampUnixtimeMs = default(long), long batchId = default(long), long mpid = default(long), string sdkVersion = default(string), ConsentState consentState = default(ConsentState), string jobId = default(string)) :
            base(sourceRequestId, context, deviceInfo, applicationInfo, userAttributes, deletedUserAttributes, userIdentities, environment, ip, integrationAttributes, partnerIdentity, sourceInfo, mpDeviceid, attributionInfo, timestampUnixtimeMs, batchId, mpid, sdkVersion, consentState, jobId)
        {
            this.Events = events ?? new Collection<BaseEvent>();
        }

        /// <summary>
        /// Create a concrete Batch from an AbstractBatch
        /// </summary>
        public Batch(BaseBatch abstractBatch) : base(abstractBatch)
        {
            this.Events = new Collection<BaseEvent>();
        }



        [DataMember(Name = "events", EmitDefaultValue = false)]
        internal List<EventWrapper> eventsWrappers
        {
            get
            {
                return Events.Select(x => new EventWrapper(x)).ToList();
            }
        }
        /// <summary>
        /// Provide a list of BaseEvent objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent
        /// </summary>
        /// <value>Provide a list of BaseEvent objects - such as CustomEvent, ScreenViewEvent, or CommerceEvent</value>
        public Collection<BaseEvent> Events { get; set; }

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
    }
}
