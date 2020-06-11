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
    /// OptOutEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class OptOutEventDataAllOf :  IEquatable<OptOutEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptOutEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OptOutEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptOutEventDataAllOf" /> class.
        /// </summary>
        /// <param name="isOptedOut">isOptedOut (required).</param>
        public OptOutEventDataAllOf(bool isOptedOut = default(bool))
        {
            this.IsOptedOut = isOptedOut;
        }
        
        /// <summary>
        /// Gets or Sets IsOptedOut
        /// </summary>
        [DataMember(Name="is_opted_out", EmitDefaultValue=false)]
        public bool IsOptedOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptOutEventDataAllOf {\n");
            sb.Append("  IsOptedOut: ").Append(IsOptedOut).Append("\n");
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
            return this.Equals(input as OptOutEventDataAllOf);
        }

        /// <summary>
        /// Returns true if OptOutEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of OptOutEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptOutEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
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
                hashCode = hashCode * 59 + this.IsOptedOut.GetHashCode();
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
