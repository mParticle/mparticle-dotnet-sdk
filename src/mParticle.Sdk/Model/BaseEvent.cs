using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json.Linq;
using mParticle.Client;

namespace mParticle.Model
{
    /// <summary>
    /// BaseEvent
    /// </summary>
    [DataContract]
    public partial class BaseEvent: IEquatable<BaseEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEvent" /> class.
        /// </summary>
        /// <param name="eventType">eventType.</param>
        public BaseEvent(EventType eventType)
        {
            this.EventType = eventType;
            this.SourceMessageId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        public EventType EventType { get; }

        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name = "timestamp_unixtime_ms", EmitDefaultValue = false)]
        public long TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name = "event_id", EmitDefaultValue = false)]
        public long EventId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceMessageId
        /// </summary>
        [DataMember(Name = "source_message_id", EmitDefaultValue = false)]
        public string SourceMessageId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "session_id", EmitDefaultValue = false)]
        public long SessionId { get; set; }

        /// <summary>
        /// Gets or Sets SessionUuid
        /// </summary>
        [DataMember(Name = "session_uuid", EmitDefaultValue = false)]
        public string SessionUuid { get; set; }

        /// <summary>
        /// Gets or Sets SessionStartUnixtimeMs
        /// </summary>
        [DataMember(Name = "session_start_unixtime_ms", EmitDefaultValue = false)]
        public int SessionStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventStartUnixtimeMs
        /// </summary>
        [DataMember(Name = "event_start_unixtime_ms", EmitDefaultValue = false)]
        public int EventStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name = "custom_attributes", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public GeoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCurrentState
        /// </summary>
        [DataMember(Name = "device_current_state", EmitDefaultValue = false)]
        public DeviceCurrentState DeviceCurrentState { get; set; }

        /// <summary>
        /// Gets or Sets IsGoalDefined
        /// </summary>
        [DataMember(Name = "is_goal_defined", EmitDefaultValue = false)]
        public bool IsGoalDefined { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueChange
        /// </summary>
        [DataMember(Name = "lifetime_value_change", EmitDefaultValue = false)]
        public bool LifetimeValueChange { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueAttributeName
        /// </summary>
        [DataMember(Name = "lifetime_value_attribute_name", EmitDefaultValue = false)]
        public string LifetimeValueAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionType
        /// </summary>
        [DataMember(Name = "data_connection_type", EmitDefaultValue = false)]
        public string DataConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets EventNum
        /// </summary>
        [DataMember(Name = "event_num", EmitDefaultValue = false)]
        public int EventNum { get; set; }

        /// <summary>
        /// Gets or Sets ViewController
        /// </summary>
        [DataMember(Name = "view_controller", EmitDefaultValue = false)]
        public string ViewController { get; set; }

        /// <summary>
        /// Gets or Sets CustomFlags
        /// </summary>
        [DataMember(Name = "custom_flags", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomFlags { get; set; }

        /// <summary>
        /// Gets or Sets IsMainThread
        /// </summary>
        [DataMember(Name = "is_main_thread", EmitDefaultValue = false)]
        public bool IsMainThread { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalName
        /// </summary>
        [DataMember(Name = "canonical_name", EmitDefaultValue = false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Gets or Sets EventSystemNotificationInfo
        /// </summary>
        [DataMember(Name = "event_system_notification_info", EmitDefaultValue = false)]
        public EventSystemNotificationInfo EventSystemNotificationInfo { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            var json = new JObject();
            var dataJson = JObject.FromObject(this);
            var eventType = dataJson.GetValue("event_type");
            dataJson.Remove("event_type");
            json.Add("data", dataJson);
            json.Add("event_type", eventType);
            return json.ToString(Formatting.None);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseEvent);
        }

        /// <summary>
        /// Returns true if BaseEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    this.EventType.Equals(input.EventType)
                ) &&
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
                hashCode = hashCode * 59 + this.EventType.GetHashCode();
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
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
