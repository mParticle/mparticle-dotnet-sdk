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
    /// UserIdentityChangeEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class UserIdentityChangeEventDataAllOf :  IEquatable<UserIdentityChangeEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityChangeEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserIdentityChangeEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentityChangeEventDataAllOf" /> class.
        /// </summary>
        /// <param name="_new">_new (required).</param>
        /// <param name="old">old (required).</param>
        public UserIdentityChangeEventDataAllOf(UserIdentity _new = default(UserIdentity), UserIdentity old = default(UserIdentity))
        {
            // to ensure "_new" is required (not null)
            this.New = _new ?? throw new ArgumentNullException("_new is a required property for UserIdentityChangeEventDataAllOf and cannot be null");
            // to ensure "old" is required (not null)
            this.Old = old ?? throw new ArgumentNullException("old is a required property for UserIdentityChangeEventDataAllOf and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets New
        /// </summary>
        [DataMember(Name="new", EmitDefaultValue=false)]
        public UserIdentity New { get; set; }

        /// <summary>
        /// Gets or Sets Old
        /// </summary>
        [DataMember(Name="old", EmitDefaultValue=false)]
        public UserIdentity Old { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentityChangeEventDataAllOf {\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Old: ").Append(Old).Append("\n");
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
            return this.Equals(input as UserIdentityChangeEventDataAllOf);
        }

        /// <summary>
        /// Returns true if UserIdentityChangeEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdentityChangeEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentityChangeEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                int hashCode = 41;
                if (this.New != null)
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
