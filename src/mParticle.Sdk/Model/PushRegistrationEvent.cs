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
    /// PushRegistrationEvent
    /// </summary>
    [DataContract]
    public partial class PushRegistrationEvent : BaseEvent, IEquatable<PushRegistrationEvent>, IValidatableObject
    {
       
        /// <summary>
        /// Initializes a new instance of the <see cref="PushRegistrationEvent" /> class.
        /// </summary>
        /// <param name="registrationToken">the push registration token.</param>
        public PushRegistrationEvent(string registrationToken): base(EventTypeEnum.Pushregistration)
        {
            this.RegistrationToken = registrationToken ?? throw new ArgumentNullException("registrationToken is a required property for PushRegistrationEventData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Register
        /// </summary>
        [DataMember(Name = "register", EmitDefaultValue = false)]
        public bool Register { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationToken
        /// </summary>
        [DataMember(Name = "registration_token", EmitDefaultValue = false)]
        public string RegistrationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushRegistrationEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  Register: ").Append(Register).Append("\n");
            sb.Append("  RegistrationToken: ").Append(RegistrationToken).Append("\n");
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
            return this.Equals(input as PushRegistrationEvent);
        }

        /// <summary>
        /// Returns true if PushRegistrationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PushRegistrationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushRegistrationEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.Register == input.Register ||
                    this.Register.Equals(input.Register)
                ) &&
                (
                    this.RegistrationToken == input.RegistrationToken ||
                    (this.RegistrationToken != null &&
                    this.RegistrationToken.Equals(input.RegistrationToken))
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
                hashCode = hashCode * 59 + this.Register.GetHashCode();
                if (this.RegistrationToken != null)
                    hashCode = hashCode * 59 + this.RegistrationToken.GetHashCode();
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
