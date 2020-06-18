using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// UserAttributeChangeEvent
    /// </summary>
    [DataContract]
    public partial class UserAttributeChangeEvent : BaseEvent, IEquatable<UserAttributeChangeEvent>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributeChangeEvent" /> class.
        /// </summary>
        /// <param name="userAttributeName">the name of the user attribute.</param>
        /// <param name="_new">the new value of the user attribute.</param>
        /// <param name="old">the old value of the user attribute.</param>
        public UserAttributeChangeEvent(string userAttributeName, object _new, object old): base(EventTypeEnum.Userattributechange)
        {
            // to ensure "userAttributeName" is required (not null)
            this.UserAttributeName = userAttributeName ?? throw new ArgumentNullException("userAttributeName is a required property for UserAttributeChangeEventData and cannot be null");
            // to ensure "_new" is required (not null)
            this.New = _new ?? throw new ArgumentNullException("_new is a required property for UserAttributeChangeEventData and cannot be null");
            // to ensure "old" is required (not null)
            this.Old = old ?? throw new ArgumentNullException("old is a required property for UserAttributeChangeEventData and cannot be null");
        }

        /// <summary>
        /// Gets or Sets UserAttributeName
        /// </summary>
        [DataMember(Name = "user_attribute_name", EmitDefaultValue = false)]
        public string UserAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public Object New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name = "old", EmitDefaultValue = false)]
        public Object Old { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets IsNewAttribute
        /// </summary>
        [DataMember(Name = "is_new_attribute", EmitDefaultValue = false)]
        public bool IsNewAttribute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAttributeChangeEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  UserAttributeName: ").Append(UserAttributeName).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  IsNewAttribute: ").Append(IsNewAttribute).Append("\n");
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
            return this.Equals(input as UserAttributeChangeEvent);
        }

        /// <summary>
        /// Returns true if UserAttributeChangeEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAttributeChangeEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAttributeChangeEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) && (
                    this.UserAttributeName == input.UserAttributeName ||
                    (this.UserAttributeName != null &&
                    this.UserAttributeName.Equals(input.UserAttributeName))
                ) &&
                (
                    this.New == input.New ||
                    (this.New != null &&
                    this.New.Equals(input.New))
                ) &&
                (
                    this.Old == input.Old ||
                    (this.Old != null &&
                    this.Old.Equals(input.Old))
                ) &&
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) &&
                (
                    this.IsNewAttribute == input.IsNewAttribute ||
                    this.IsNewAttribute.Equals(input.IsNewAttribute)
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
                if (this.UserAttributeName != null)
                    hashCode = hashCode * 59 + this.UserAttributeName.GetHashCode();
                if (this.New != null)
                    hashCode = hashCode * 59 + this.New.GetHashCode();
                if (this.Old != null)
                    hashCode = hashCode * 59 + this.Old.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                hashCode = hashCode * 59 + this.IsNewAttribute.GetHashCode();
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
