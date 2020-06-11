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
    /// PushRegistrationEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class PushRegistrationEventDataAllOf :  IEquatable<PushRegistrationEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushRegistrationEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushRegistrationEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushRegistrationEventDataAllOf" /> class.
        /// </summary>
        /// <param name="register">register (required).</param>
        /// <param name="registrationToken">registrationToken (required).</param>
        public PushRegistrationEventDataAllOf(bool register = default(bool), string registrationToken = default(string))
        {
            this.Register = register;
            // to ensure "registrationToken" is required (not null)
            this.RegistrationToken = registrationToken ?? throw new ArgumentNullException("registrationToken is a required property for PushRegistrationEventDataAllOf and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Register
        /// </summary>
        [DataMember(Name="register", EmitDefaultValue=false)]
        public bool Register { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationToken
        /// </summary>
        [DataMember(Name="registration_token", EmitDefaultValue=false)]
        public string RegistrationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushRegistrationEventDataAllOf {\n");
            sb.Append("  Register: ").Append(Register).Append("\n");
            sb.Append("  RegistrationToken: ").Append(RegistrationToken).Append("\n");
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
            return this.Equals(input as PushRegistrationEventDataAllOf);
        }

        /// <summary>
        /// Returns true if PushRegistrationEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PushRegistrationEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushRegistrationEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                int hashCode = 41;
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
