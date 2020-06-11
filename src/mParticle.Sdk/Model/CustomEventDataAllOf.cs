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
    /// CustomEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class CustomEventDataAllOf :  IEquatable<CustomEventDataAllOf>, IValidatableObject
    {
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

        /// <summary>
        /// Gets or Sets CustomEventType
        /// </summary>
        [DataMember(Name="custom_event_type", EmitDefaultValue=false)]
        public CustomEventTypeEnum CustomEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventDataAllOf" /> class.
        /// </summary>
        /// <param name="customEventType">customEventType (required) (default to CustomEventTypeEnum.Other).</param>
        /// <param name="eventName">eventName (required).</param>
        /// <param name="customFlags">customFlags.</param>
        public CustomEventDataAllOf(CustomEventTypeEnum customEventType = CustomEventTypeEnum.Other, string eventName = default(string), Dictionary<string, string> customFlags = default(Dictionary<string, string>))
        {
            this.CustomEventType = customEventType;
            // to ensure "eventName" is required (not null)
            this.EventName = eventName ?? throw new ArgumentNullException("eventName is a required property for CustomEventDataAllOf and cannot be null");
            this.CustomFlags = customFlags;
        }
        
        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets CustomFlags
        /// </summary>
        [DataMember(Name="custom_flags", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomEventDataAllOf {\n");
            sb.Append("  CustomEventType: ").Append(CustomEventType).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CustomFlags: ").Append(CustomFlags).Append("\n");
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
            return this.Equals(input as CustomEventDataAllOf);
        }

        /// <summary>
        /// Returns true if CustomEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomEventType == input.CustomEventType ||
                    this.CustomEventType.Equals(input.CustomEventType)
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.CustomFlags == input.CustomFlags ||
                    this.CustomFlags != null &&
                    input.CustomFlags != null &&
                    this.CustomFlags.SequenceEqual(input.CustomFlags)
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
                hashCode = hashCode * 59 + this.CustomEventType.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.CustomFlags != null)
                    hashCode = hashCode * 59 + this.CustomFlags.GetHashCode();
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
