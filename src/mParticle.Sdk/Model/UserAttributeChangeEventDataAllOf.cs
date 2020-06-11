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
    /// UserAttributeChangeEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class UserAttributeChangeEventDataAllOf :  IEquatable<UserAttributeChangeEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributeChangeEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserAttributeChangeEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributeChangeEventDataAllOf" /> class.
        /// </summary>
        /// <param name="userAttributeName">userAttributeName (required).</param>
        /// <param name="_new">_new (required).</param>
        /// <param name="old">old (required).</param>
        /// <param name="deleted">deleted (required).</param>
        /// <param name="isNewAttribute">isNewAttribute (required).</param>
        public UserAttributeChangeEventDataAllOf(string userAttributeName = default(string), Object _new = default(Object), Object old = default(Object), bool deleted = default(bool), bool isNewAttribute = default(bool))
        {
            // to ensure "userAttributeName" is required (not null)
            this.UserAttributeName = userAttributeName ?? throw new ArgumentNullException("userAttributeName is a required property for UserAttributeChangeEventDataAllOf and cannot be null");
            // to ensure "_new" is required (not null)
            this.New = _new ?? throw new ArgumentNullException("_new is a required property for UserAttributeChangeEventDataAllOf and cannot be null");
            // to ensure "old" is required (not null)
            this.Old = old ?? throw new ArgumentNullException("old is a required property for UserAttributeChangeEventDataAllOf and cannot be null");
            this.Deleted = deleted;
            this.IsNewAttribute = isNewAttribute;
        }
        
        /// <summary>
        /// Gets or Sets UserAttributeName
        /// </summary>
        [DataMember(Name="user_attribute_name", EmitDefaultValue=false)]
        public string UserAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name="new", EmitDefaultValue=false)]
        public Object New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name="old", EmitDefaultValue=false)]
        public Object Old { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets IsNewAttribute
        /// </summary>
        [DataMember(Name="is_new_attribute", EmitDefaultValue=false)]
        public bool IsNewAttribute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAttributeChangeEventDataAllOf {\n");
            sb.Append("  UserAttributeName: ").Append(UserAttributeName).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  IsNewAttribute: ").Append(IsNewAttribute).Append("\n");
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
            return this.Equals(input as UserAttributeChangeEventDataAllOf);
        }

        /// <summary>
        /// Returns true if UserAttributeChangeEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAttributeChangeEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAttributeChangeEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
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
                int hashCode = 41;
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
