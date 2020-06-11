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
    /// ApplicationStateTransitionEventData
    /// </summary>
    [DataContract]
    public partial class ApplicationStateTransitionEventData :  IEquatable<ApplicationStateTransitionEventData>, IValidatableObject
    {
        /// <summary>
        /// Defines ApplicationTransitionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationTransitionTypeEnum
        {
            /// <summary>
            /// Enum Initialized for value: application_initialized
            /// </summary>
            [EnumMember(Value = "application_initialized")]
            Initialized = 1,

            /// <summary>
            /// Enum Exit for value: application_exit
            /// </summary>
            [EnumMember(Value = "application_exit")]
            Exit = 2,

            /// <summary>
            /// Enum Background for value: application_background
            /// </summary>
            [EnumMember(Value = "application_background")]
            Background = 3,

            /// <summary>
            /// Enum Foreground for value: application_foreground
            /// </summary>
            [EnumMember(Value = "application_foreground")]
            Foreground = 4

        }

        /// <summary>
        /// Gets or Sets ApplicationTransitionType
        /// </summary>
        [DataMember(Name="application_transition_type", EmitDefaultValue=false)]
        public ApplicationTransitionTypeEnum ApplicationTransitionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationStateTransitionEventData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationStateTransitionEventData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationStateTransitionEventData" /> class.
        /// </summary>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs.</param>
        /// <param name="sourceMessageId">sourceMessageId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="sessionUuid">sessionUuid.</param>
        /// <param name="sessionStartUnixtimeMs">sessionStartUnixtimeMs.</param>
        /// <param name="eventStartUnixtimeMs">eventStartUnixtimeMs.</param>
        /// <param name="customAttributes">customAttributes.</param>
        /// <param name="location">location.</param>
        /// <param name="deviceCurrentState">deviceCurrentState.</param>
        /// <param name="isGoalDefined">isGoalDefined.</param>
        /// <param name="lifetimeValueChange">lifetimeValueChange.</param>
        /// <param name="lifetimeValueAttributeName">lifetimeValueAttributeName.</param>
        /// <param name="dataConnectionType">dataConnectionType.</param>
        /// <param name="eventNum">eventNum.</param>
        /// <param name="viewController">viewController.</param>
        /// <param name="isMainThread">isMainThread.</param>
        /// <param name="canonicalName">canonicalName.</param>
        /// <param name="eventSystemNotificationInfo">eventSystemNotificationInfo.</param>
        /// <param name="successfullyClosed">successfullyClosed.</param>
        /// <param name="isFirstRun">isFirstRun (required).</param>
        /// <param name="isUpgrade">isUpgrade (required).</param>
        /// <param name="pushNotificationPayload">pushNotificationPayload.</param>
        /// <param name="launchReferral">launchReferral.</param>
        /// <param name="applicationTransitionType">applicationTransitionType (required).</param>
        public ApplicationStateTransitionEventData(int timestampUnixtimeMs = default(int), string sourceMessageId = default(string), long sessionId = default(long), string sessionUuid = default(string), int sessionStartUnixtimeMs = default(int), int eventStartUnixtimeMs = default(int), Dictionary<string, string> customAttributes = default(Dictionary<string, string>), GeoLocation location = default(GeoLocation), DeviceCurrentState deviceCurrentState = default(DeviceCurrentState), bool isGoalDefined = default(bool), bool lifetimeValueChange = default(bool), string lifetimeValueAttributeName = default(string), string dataConnectionType = default(string), int eventNum = default(int), string viewController = default(string), bool isMainThread = default(bool), string canonicalName = default(string), EventSystemNotificationInfo eventSystemNotificationInfo = default(EventSystemNotificationInfo), bool successfullyClosed = default(bool), bool isFirstRun = default(bool), bool isUpgrade = default(bool), string pushNotificationPayload = default(string), string launchReferral = default(string), ApplicationTransitionTypeEnum applicationTransitionType = default(ApplicationTransitionTypeEnum))
        {
            this.IsFirstRun = isFirstRun;
            this.IsUpgrade = isUpgrade;
            this.ApplicationTransitionType = applicationTransitionType;
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            this.SourceMessageId = sourceMessageId;
            this.SessionId = sessionId;
            this.SessionUuid = sessionUuid;
            this.SessionStartUnixtimeMs = sessionStartUnixtimeMs;
            this.EventStartUnixtimeMs = eventStartUnixtimeMs;
            this.CustomAttributes = customAttributes;
            this.Location = location;
            this.DeviceCurrentState = deviceCurrentState;
            this.IsGoalDefined = isGoalDefined;
            this.LifetimeValueChange = lifetimeValueChange;
            this.LifetimeValueAttributeName = lifetimeValueAttributeName;
            this.DataConnectionType = dataConnectionType;
            this.EventNum = eventNum;
            this.ViewController = viewController;
            this.IsMainThread = isMainThread;
            this.CanonicalName = canonicalName;
            this.EventSystemNotificationInfo = eventSystemNotificationInfo;
            this.SuccessfullyClosed = successfullyClosed;
            this.PushNotificationPayload = pushNotificationPayload;
            this.LaunchReferral = launchReferral;
        }
        
        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public int TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public long EventId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceMessageId
        /// </summary>
        [DataMember(Name="source_message_id", EmitDefaultValue=false)]
        public string SourceMessageId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public long SessionId { get; set; }

        /// <summary>
        /// Gets or Sets SessionUuid
        /// </summary>
        [DataMember(Name="session_uuid", EmitDefaultValue=false)]
        public string SessionUuid { get; set; }

        /// <summary>
        /// Gets or Sets SessionStartUnixtimeMs
        /// </summary>
        [DataMember(Name="session_start_unixtime_ms", EmitDefaultValue=false)]
        public int SessionStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventStartUnixtimeMs
        /// </summary>
        [DataMember(Name="event_start_unixtime_ms", EmitDefaultValue=false)]
        public int EventStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public GeoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCurrentState
        /// </summary>
        [DataMember(Name="device_current_state", EmitDefaultValue=false)]
        public DeviceCurrentState DeviceCurrentState { get; set; }

        /// <summary>
        /// Gets or Sets IsGoalDefined
        /// </summary>
        [DataMember(Name="is_goal_defined", EmitDefaultValue=false)]
        public bool IsGoalDefined { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueChange
        /// </summary>
        [DataMember(Name="lifetime_value_change", EmitDefaultValue=false)]
        public bool LifetimeValueChange { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueAttributeName
        /// </summary>
        [DataMember(Name="lifetime_value_attribute_name", EmitDefaultValue=false)]
        public string LifetimeValueAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionType
        /// </summary>
        [DataMember(Name="data_connection_type", EmitDefaultValue=false)]
        public string DataConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets EventNum
        /// </summary>
        [DataMember(Name="event_num", EmitDefaultValue=false)]
        public int EventNum { get; set; }

        /// <summary>
        /// Gets or Sets ViewController
        /// </summary>
        [DataMember(Name="view_controller", EmitDefaultValue=false)]
        public string ViewController { get; set; }

        /// <summary>
        /// Gets or Sets IsMainThread
        /// </summary>
        [DataMember(Name="is_main_thread", EmitDefaultValue=false)]
        public bool IsMainThread { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalName
        /// </summary>
        [DataMember(Name="canonical_name", EmitDefaultValue=false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Gets or Sets EventSystemNotificationInfo
        /// </summary>
        [DataMember(Name="event_system_notification_info", EmitDefaultValue=false)]
        public EventSystemNotificationInfo EventSystemNotificationInfo { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfullyClosed
        /// </summary>
        [DataMember(Name="successfully_closed", EmitDefaultValue=false)]
        public bool SuccessfullyClosed { get; set; }

        /// <summary>
        /// Gets or Sets IsFirstRun
        /// </summary>
        [DataMember(Name="is_first_run", EmitDefaultValue=false)]
        public bool IsFirstRun { get; set; }

        /// <summary>
        /// Gets or Sets IsUpgrade
        /// </summary>
        [DataMember(Name="is_upgrade", EmitDefaultValue=false)]
        public bool IsUpgrade { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationPayload
        /// </summary>
        [DataMember(Name="push_notification_payload", EmitDefaultValue=false)]
        public string PushNotificationPayload { get; set; }

        /// <summary>
        /// Gets or Sets LaunchReferral
        /// </summary>
        [DataMember(Name="launch_referral", EmitDefaultValue=false)]
        public string LaunchReferral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationStateTransitionEventData {\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  SourceMessageId: ").Append(SourceMessageId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionUuid: ").Append(SessionUuid).Append("\n");
            sb.Append("  SessionStartUnixtimeMs: ").Append(SessionStartUnixtimeMs).Append("\n");
            sb.Append("  EventStartUnixtimeMs: ").Append(EventStartUnixtimeMs).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceCurrentState: ").Append(DeviceCurrentState).Append("\n");
            sb.Append("  IsGoalDefined: ").Append(IsGoalDefined).Append("\n");
            sb.Append("  LifetimeValueChange: ").Append(LifetimeValueChange).Append("\n");
            sb.Append("  LifetimeValueAttributeName: ").Append(LifetimeValueAttributeName).Append("\n");
            sb.Append("  DataConnectionType: ").Append(DataConnectionType).Append("\n");
            sb.Append("  EventNum: ").Append(EventNum).Append("\n");
            sb.Append("  ViewController: ").Append(ViewController).Append("\n");
            sb.Append("  IsMainThread: ").Append(IsMainThread).Append("\n");
            sb.Append("  CanonicalName: ").Append(CanonicalName).Append("\n");
            sb.Append("  EventSystemNotificationInfo: ").Append(EventSystemNotificationInfo).Append("\n");
            sb.Append("  SuccessfullyClosed: ").Append(SuccessfullyClosed).Append("\n");
            sb.Append("  IsFirstRun: ").Append(IsFirstRun).Append("\n");
            sb.Append("  IsUpgrade: ").Append(IsUpgrade).Append("\n");
            sb.Append("  PushNotificationPayload: ").Append(PushNotificationPayload).Append("\n");
            sb.Append("  LaunchReferral: ").Append(LaunchReferral).Append("\n");
            sb.Append("  ApplicationTransitionType: ").Append(ApplicationTransitionType).Append("\n");
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
            return this.Equals(input as ApplicationStateTransitionEventData);
        }

        /// <summary>
        /// Returns true if ApplicationStateTransitionEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationStateTransitionEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationStateTransitionEventData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && 
                (
                    this.SourceMessageId == input.SourceMessageId ||
                    (this.SourceMessageId != null &&
                    this.SourceMessageId.Equals(input.SourceMessageId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    this.SessionId.Equals(input.SessionId)
                ) && 
                (
                    this.SessionUuid == input.SessionUuid ||
                    (this.SessionUuid != null &&
                    this.SessionUuid.Equals(input.SessionUuid))
                ) && 
                (
                    this.SessionStartUnixtimeMs == input.SessionStartUnixtimeMs ||
                    this.SessionStartUnixtimeMs.Equals(input.SessionStartUnixtimeMs)
                ) && 
                (
                    this.EventStartUnixtimeMs == input.EventStartUnixtimeMs ||
                    this.EventStartUnixtimeMs.Equals(input.EventStartUnixtimeMs)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DeviceCurrentState == input.DeviceCurrentState ||
                    (this.DeviceCurrentState != null &&
                    this.DeviceCurrentState.Equals(input.DeviceCurrentState))
                ) && 
                (
                    this.IsGoalDefined == input.IsGoalDefined ||
                    this.IsGoalDefined.Equals(input.IsGoalDefined)
                ) && 
                (
                    this.LifetimeValueChange == input.LifetimeValueChange ||
                    this.LifetimeValueChange.Equals(input.LifetimeValueChange)
                ) && 
                (
                    this.LifetimeValueAttributeName == input.LifetimeValueAttributeName ||
                    (this.LifetimeValueAttributeName != null &&
                    this.LifetimeValueAttributeName.Equals(input.LifetimeValueAttributeName))
                ) && 
                (
                    this.DataConnectionType == input.DataConnectionType ||
                    (this.DataConnectionType != null &&
                    this.DataConnectionType.Equals(input.DataConnectionType))
                ) && 
                (
                    this.EventNum == input.EventNum ||
                    this.EventNum.Equals(input.EventNum)
                ) && 
                (
                    this.ViewController == input.ViewController ||
                    (this.ViewController != null &&
                    this.ViewController.Equals(input.ViewController))
                ) && 
                (
                    this.IsMainThread == input.IsMainThread ||
                    this.IsMainThread.Equals(input.IsMainThread)
                ) && 
                (
                    this.CanonicalName == input.CanonicalName ||
                    (this.CanonicalName != null &&
                    this.CanonicalName.Equals(input.CanonicalName))
                ) && 
                (
                    this.EventSystemNotificationInfo == input.EventSystemNotificationInfo ||
                    (this.EventSystemNotificationInfo != null &&
                    this.EventSystemNotificationInfo.Equals(input.EventSystemNotificationInfo))
                ) && 
                (
                    this.SuccessfullyClosed == input.SuccessfullyClosed ||
                    this.SuccessfullyClosed.Equals(input.SuccessfullyClosed)
                ) && 
                (
                    this.IsFirstRun == input.IsFirstRun ||
                    this.IsFirstRun.Equals(input.IsFirstRun)
                ) && 
                (
                    this.IsUpgrade == input.IsUpgrade ||
                    this.IsUpgrade.Equals(input.IsUpgrade)
                ) && 
                (
                    this.PushNotificationPayload == input.PushNotificationPayload ||
                    (this.PushNotificationPayload != null &&
                    this.PushNotificationPayload.Equals(input.PushNotificationPayload))
                ) && 
                (
                    this.LaunchReferral == input.LaunchReferral ||
                    (this.LaunchReferral != null &&
                    this.LaunchReferral.Equals(input.LaunchReferral))
                ) && 
                (
                    this.ApplicationTransitionType == input.ApplicationTransitionType ||
                    this.ApplicationTransitionType.Equals(input.ApplicationTransitionType)
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
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.SourceMessageId != null)
                    hashCode = hashCode * 59 + this.SourceMessageId.GetHashCode();
                hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.SessionUuid != null)
                    hashCode = hashCode * 59 + this.SessionUuid.GetHashCode();
                hashCode = hashCode * 59 + this.SessionStartUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventStartUnixtimeMs.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DeviceCurrentState != null)
                    hashCode = hashCode * 59 + this.DeviceCurrentState.GetHashCode();
                hashCode = hashCode * 59 + this.IsGoalDefined.GetHashCode();
                hashCode = hashCode * 59 + this.LifetimeValueChange.GetHashCode();
                if (this.LifetimeValueAttributeName != null)
                    hashCode = hashCode * 59 + this.LifetimeValueAttributeName.GetHashCode();
                if (this.DataConnectionType != null)
                    hashCode = hashCode * 59 + this.DataConnectionType.GetHashCode();
                hashCode = hashCode * 59 + this.EventNum.GetHashCode();
                if (this.ViewController != null)
                    hashCode = hashCode * 59 + this.ViewController.GetHashCode();
                hashCode = hashCode * 59 + this.IsMainThread.GetHashCode();
                if (this.CanonicalName != null)
                    hashCode = hashCode * 59 + this.CanonicalName.GetHashCode();
                if (this.EventSystemNotificationInfo != null)
                    hashCode = hashCode * 59 + this.EventSystemNotificationInfo.GetHashCode();
                hashCode = hashCode * 59 + this.SuccessfullyClosed.GetHashCode();
                hashCode = hashCode * 59 + this.IsFirstRun.GetHashCode();
                hashCode = hashCode * 59 + this.IsUpgrade.GetHashCode();
                if (this.PushNotificationPayload != null)
                    hashCode = hashCode * 59 + this.PushNotificationPayload.GetHashCode();
                if (this.LaunchReferral != null)
                    hashCode = hashCode * 59 + this.LaunchReferral.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationTransitionType.GetHashCode();
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
