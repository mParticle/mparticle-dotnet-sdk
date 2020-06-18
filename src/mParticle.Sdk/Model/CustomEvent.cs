using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using EventTypeEnum = mParticle.Model.EventType;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using mParticle.Client;

namespace mParticle.Model
{
    /// <summary>
    /// CustomEvent
    /// </summary>
    [DataContract]
    public partial class CustomEvent :  BaseEvent, IEquatable<CustomEvent>, IValidatableObject
    {
       
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEvent" /> class.
        /// </summary>
        /// <param name="eventName">the event name.</param>
        /// <param name="customEventType">the custom event type</param>
        public CustomEvent(string eventName, CustomEventTypeEnum customEventType = CustomEventTypeEnum.Other): base(EventTypeEnum.Customevent) 
        {
            EventName = eventName;
            CustomEventType = customEventType;
        }

        /// <summary>
        /// Gets or Sets CustomEventType
        /// </summary>
        [DataMember(Name="custom_event_type", EmitDefaultValue=false)]
        public CustomEventTypeEnum CustomEventType { get; set; }
   
        
        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CustomEventType: ").Append(CustomEventType).Append("\n");
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
            return this.Equals(input as CustomEvent);
        }

        /// <summary>
        /// Returns true if CustomEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEvent input)
        {
            if (input == null)
                return false;

            return 
                base.Equals(input) && (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.CustomEventType == input.CustomEventType
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
                int hashCode = base.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.CustomEventType.GetHashCode();
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

        /// <summary>
        /// Defines CustomEventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomEventTypeEnum
        {
            /// <summary>
            /// Enum Navigation for value: navigation
            /// </summary>
            [EnumMember(Value = "navigation")]
            Navigation = 1,

            /// <summary>
            /// Enum Location for value: location
            /// </summary>
            [EnumMember(Value = "location")]
            Location = 2,

            /// <summary>
            /// Enum Search for value: search
            /// </summary>
            [EnumMember(Value = "search")]
            Search = 3,

            /// <summary>
            /// Enum Transaction for value: transaction
            /// </summary>
            [EnumMember(Value = "transaction")]
            Transaction = 4,

            /// <summary>
            /// Enum Usercontent for value: user_content
            /// </summary>
            [EnumMember(Value = "user_content")]
            Usercontent = 5,

            /// <summary>
            /// Enum Userpreference for value: user_preference
            /// </summary>
            [EnumMember(Value = "user_preference")]
            Userpreference = 6,

            /// <summary>
            /// Enum Social for value: social
            /// </summary>
            [EnumMember(Value = "social")]
            Social = 7,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 8

        }
    }

}
