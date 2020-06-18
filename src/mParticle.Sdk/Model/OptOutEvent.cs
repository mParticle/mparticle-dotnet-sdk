using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// OptOutEvent
    /// </summary>
    [DataContract]
    public partial class OptOutEvent : BaseEvent, IEquatable<OptOutEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="OptOutEvent" /> class.
        /// </summary>
        public OptOutEvent(): base(EventTypeEnum.Optout)
        {}

        /// <summary>
        /// Gets or Sets IsOptedOut
        /// </summary>
        [DataMember(Name = "is_opted_out", EmitDefaultValue = false)]
        public bool IsOptedOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptOutEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  IsOptedOut: ").Append(IsOptedOut).Append("\n");
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
            return this.Equals(input as OptOutEvent);
        }

        /// <summary>
        /// Returns true if OptOutEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of OptOutEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptOutEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.IsOptedOut == input.IsOptedOut ||
                    this.IsOptedOut.Equals(input.IsOptedOut)
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
                hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.IsOptedOut.GetHashCode();
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
