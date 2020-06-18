using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// ScreenViewEvent
    /// </summary>
    [DataContract]
    public partial class ScreenViewEvent : BaseEvent, IEquatable<ScreenViewEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenViewEvent" /> class.
        /// </summary>
        public ScreenViewEvent(string screenName): base(EventTypeEnum.Screenview) 
        {
            this.ScreenName = screenName ?? throw new ArgumentNullException("screenName is a required property for ScreenViewEventData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets ScreenName
        /// </summary>
        [DataMember(Name = "screen_name", EmitDefaultValue = false)]
        public string ScreenName { get; set; }

        /// <summary>
        /// Gets or Sets ActivityType
        /// </summary>
        [DataMember(Name = "activity_type", EmitDefaultValue = false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenViewEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
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
            return this.Equals(input as ScreenViewEvent);
        }

        /// <summary>
        /// Returns true if ScreenViewEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenViewEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenViewEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.ScreenName == input.ScreenName ||
                    (this.ScreenName != null &&
                    this.ScreenName.Equals(input.ScreenName))
                ) &&
                (
                    this.ActivityType == input.ActivityType ||
                    (this.ActivityType != null &&
                    this.ActivityType.Equals(input.ActivityType))
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
                if (this.ScreenName != null)
                    hashCode = hashCode * 59 + this.ScreenName.GetHashCode();
                if (this.ActivityType != null)
                    hashCode = hashCode * 59 + this.ActivityType.GetHashCode();
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
