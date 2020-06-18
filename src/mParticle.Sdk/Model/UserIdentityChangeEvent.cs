using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// UserIdentityChangeEvent
    /// </summary>
    [DataContract]
    public partial class UserIdentityChangeEvent : BaseEvent, IEquatable<UserIdentityChangeEvent>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityChangeEvent" /> class.
        /// </summary>
        /// <param name="_new">the new user identity value.</param>
        /// <param name="old">the old user identity value.</param>
        public UserIdentityChangeEvent(UserIdentity _new, UserIdentity old) : base(EventTypeEnum.Useridentitychange)
        {
            // to ensure "_new" is required (not null)
            this.New = _new ?? throw new ArgumentNullException("_new is a required property for UserIdentityChangeEventData and cannot be null");
            // to ensure "old" is required (not null)
            this.Old = old ?? throw new ArgumentNullException("old is a required property for UserIdentityChangeEventData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public UserIdentity New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", EmitDefaultValue = false)]
        public UserIdentity Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentityChangeEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
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
            return this.Equals(input as UserIdentityChangeEvent);
        }

        /// <summary>
        /// Returns true if UserIdentityChangeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdentityChangeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentityChangeEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.New == input.New ||
                    (this.New != null &&
                    this.New.Equals(input.New))
                ) &&
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
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
                if(this.New != null)
                    hashCode = hashCode * 59 + this.New.GetHashCode();
                if (this.Old != null)
                    hashCode = hashCode * 59 + this.Old.GetHashCode();
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
