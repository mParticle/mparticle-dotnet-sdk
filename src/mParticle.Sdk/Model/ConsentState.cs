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
    /// ConsentState
    /// </summary>
    [DataContract]
    public partial class ConsentState :  IEquatable<ConsentState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentState" /> class.
        /// </summary>
        /// <param name="gdpr">gdpr (required).</param>
        public ConsentState(GDPRConsentState gdpr = default(GDPRConsentState))
        {
            // to ensure "gdpr" is required (not null)
            this.Gdpr = gdpr ?? throw new ArgumentNullException("gdpr is a required property for ConsentState and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Gdpr
        /// </summary>
        [DataMember(Name="gdpr", EmitDefaultValue=false)]
        public GDPRConsentState Gdpr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentState {\n");
            sb.Append("  Gdpr: ").Append(Gdpr).Append("\n");
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
            return this.Equals(input as ConsentState);
        }

        /// <summary>
        /// Returns true if ConsentState instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gdpr == input.Gdpr ||
                    (this.Gdpr != null &&
                    this.Gdpr.Equals(input.Gdpr))
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
                if (this.Gdpr != null)
                    hashCode = hashCode * 59 + this.Gdpr.GetHashCode();
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
