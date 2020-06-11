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
    /// PushMessageEventData
    /// </summary>
    [DataContract]
    public partial class PushMessageEventData :  IEquatable<PushMessageEventData>, IValidatableObject
    {
        /// <summary>
        /// Defines PushMessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PushMessageTypeEnum
        {
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 1,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 2,

            /// <summary>
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 3

        }

        /// <summary>
        /// Gets or Sets PushMessageType
        /// </summary>
        [DataMember(Name="push_message_type", EmitDefaultValue=false)]
        public PushMessageTypeEnum PushMessageType { get; set; }
        /// <summary>
        /// Defines ApplicationState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationStateEnum
        {
            /// <summary>
            /// Enum Notrunning for value: not_running
            /// </summary>
            [EnumMember(Value = "not_running")]
            Notrunning = 1,

            /// <summary>
            /// Enum Background for value: background
            /// </summary>
            [EnumMember(Value = "background")]
            Background = 2,

            /// <summary>
            /// Enum Foreground for value: foreground
            /// </summary>
            [EnumMember(Value = "foreground")]
            Foreground = 3

        }

        /// <summary>
        /// Gets or Sets ApplicationState
        /// </summary>
        [DataMember(Name="application_state", EmitDefaultValue=false)]
        public ApplicationStateEnum? ApplicationState { get; set; }
        /// <summary>
        /// Defines PushMessageBehavior
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PushMessageBehaviorEnum
        {
            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 1,

            /// <summary>
            /// Enum DirectOpen for value: DirectOpen
            /// </summary>
            [EnumMember(Value = "DirectOpen")]
            DirectOpen = 2,

            /// <summary>
            /// Enum Read for value: Read
            /// </summary>
            [EnumMember(Value = "Read")]
            Read = 3,

            /// <summary>
            /// Enum InfluencedOpen for value: InfluencedOpen
            /// </summary>
            [EnumMember(Value = "InfluencedOpen")]
            InfluencedOpen = 4,

            /// <summary>
            /// Enum Displayed for value: Displayed
            /// </summary>
            [EnumMember(Value = "Displayed")]
            Displayed = 5

        }

        /// <summary>
        /// Gets or Sets PushMessageBehavior
        /// </summary>
        [DataMember(Name="push_message_behavior", EmitDefaultValue=false)]
        public PushMessageBehaviorEnum? PushMessageBehavior { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMessageEventData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushMessageEventData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMessageEventData" /> class.
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
        /// <param name="pushMessageToken">pushMessageToken (required).</param>
        /// <param name="pushMessageType">pushMessageType (required).</param>
        /// <param name="message">message.</param>
        /// <param name="network">network.</param>
        /// <param name="pushNotificationPayload">pushNotificationPayload (required).</param>
        /// <param name="applicationState">applicationState.</param>
        /// <param name="actionIdentifier">actionIdentifier.</param>
        /// <param name="pushMessageBehavior">pushMessageBehavior.</param>
        public PushMessageEventData(int timestampUnixtimeMs = default(int), string sourceMessageId = default(string), long sessionId = default(long), string sessionUuid = default(string), int sessionStartUnixtimeMs = default(int), int eventStartUnixtimeMs = default(int), Dictionary<string, string> customAttributes = default(Dictionary<string, string>), GeoLocation location = default(GeoLocation), DeviceCurrentState deviceCurrentState = default(DeviceCurrentState), bool isGoalDefined = default(bool), bool lifetimeValueChange = default(bool), string lifetimeValueAttributeName = default(string), string dataConnectionType = default(string), int eventNum = default(int), string viewController = default(string), bool isMainThread = default(bool), string canonicalName = default(string), EventSystemNotificationInfo eventSystemNotificationInfo = default(EventSystemNotificationInfo), string pushMessageToken = default(string), PushMessageTypeEnum pushMessageType = default(PushMessageTypeEnum), string message = default(string), string network = default(string), string pushNotificationPayload = default(string), ApplicationStateEnum? applicationState = default(ApplicationStateEnum?), string actionIdentifier = default(string), PushMessageBehaviorEnum? pushMessageBehavior = default(PushMessageBehaviorEnum?))
        {
            // to ensure "pushMessageToken" is required (not null)
            this.PushMessageToken = pushMessageToken ?? throw new ArgumentNullException("pushMessageToken is a required property for PushMessageEventData and cannot be null");
            this.PushMessageType = pushMessageType;
            // to ensure "pushNotificationPayload" is required (not null)
            this.PushNotificationPayload = pushNotificationPayload ?? throw new ArgumentNullException("pushNotificationPayload is a required property for PushMessageEventData and cannot be null");
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
            this.Message = message;
            this.Network = network;
            this.ApplicationState = applicationState;
            this.ActionIdentifier = actionIdentifier;
            this.PushMessageBehavior = pushMessageBehavior;
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
        /// Gets or Sets PushMessageToken
        /// </summary>
        [DataMember(Name="push_message_token", EmitDefaultValue=false)]
        public string PushMessageToken { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationPayload
        /// </summary>
        [DataMember(Name="push_notification_payload", EmitDefaultValue=false)]
        public string PushNotificationPayload { get; set; }

        /// <summary>
        /// Gets or Sets ActionIdentifier
        /// </summary>
        [DataMember(Name="action_identifier", EmitDefaultValue=false)]
        public string ActionIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushMessageEventData {\n");
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
            sb.Append("  PushMessageToken: ").Append(PushMessageToken).Append("\n");
            sb.Append("  PushMessageType: ").Append(PushMessageType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  PushNotificationPayload: ").Append(PushNotificationPayload).Append("\n");
            sb.Append("  ApplicationState: ").Append(ApplicationState).Append("\n");
            sb.Append("  ActionIdentifier: ").Append(ActionIdentifier).Append("\n");
            sb.Append("  PushMessageBehavior: ").Append(PushMessageBehavior).Append("\n");
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
            return this.Equals(input as PushMessageEventData);
        }

        /// <summary>
        /// Returns true if PushMessageEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of PushMessageEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushMessageEventData input)
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
                    this.PushMessageToken == input.PushMessageToken ||
                    (this.PushMessageToken != null &&
                    this.PushMessageToken.Equals(input.PushMessageToken))
                ) && 
                (
                    this.PushMessageType == input.PushMessageType ||
                    this.PushMessageType.Equals(input.PushMessageType)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.PushNotificationPayload == input.PushNotificationPayload ||
                    (this.PushNotificationPayload != null &&
                    this.PushNotificationPayload.Equals(input.PushNotificationPayload))
                ) && 
                (
                    this.ApplicationState == input.ApplicationState ||
                    this.ApplicationState.Equals(input.ApplicationState)
                ) && 
                (
                    this.ActionIdentifier == input.ActionIdentifier ||
                    (this.ActionIdentifier != null &&
                    this.ActionIdentifier.Equals(input.ActionIdentifier))
                ) && 
                (
                    this.PushMessageBehavior == input.PushMessageBehavior ||
                    this.PushMessageBehavior.Equals(input.PushMessageBehavior)
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
                if (this.PushMessageToken != null)
                    hashCode = hashCode * 59 + this.PushMessageToken.GetHashCode();
                hashCode = hashCode * 59 + this.PushMessageType.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.PushNotificationPayload != null)
                    hashCode = hashCode * 59 + this.PushNotificationPayload.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationState.GetHashCode();
                if (this.ActionIdentifier != null)
                    hashCode = hashCode * 59 + this.ActionIdentifier.GetHashCode();
                hashCode = hashCode * 59 + this.PushMessageBehavior.GetHashCode();
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
