using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using EventTypeEnum = mParticle.Model.EventType;
using System.Linq;

namespace mParticle.Model
{
    /// <summary>
    /// BreadcrumbEvent
    /// </summary>
    [DataContract]
    public partial class BreadcrumbEvent : BaseEvent, IEquatable<BreadcrumbEvent>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbEvent" /> class.
        /// </summary>
        /// <param name="label">label (required).</param>
        public BreadcrumbEvent(string label) : base(EventTypeEnum.Breadcrumb)
        {
            Label = label ?? throw new ArgumentNullException("label is a required property for BreadcrumbEventData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets SessionNumber
        /// </summary>
        [DataMember(Name = "session_number", EmitDefaultValue = false)]
        public int SessionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreadcrumbEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  SessionNumber: ").Append(SessionNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as BreadcrumbEvent);
        }

        /// <summary>
        /// Returns true if BreadcrumbEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BreadcrumbEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreadcrumbEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) &&
                (
                    this.SessionNumber == input.SessionNumber
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                hashCode = hashCode * 59 + this.SessionNumber.GetHashCode();
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
