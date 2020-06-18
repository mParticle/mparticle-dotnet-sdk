using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace mParticle.Model
{
    /// <summary>
    /// ConsentState
    /// </summary>
    [DataContract]
    public partial class ConsentState :  IEquatable<ConsentState>, IValidatableObject
    {
        const string CCPA_KEY = "data_sale_opt_out";

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ConsentState(Dictionary<string, ConsentInstance> gdprConsentState = default(Dictionary<string, ConsentInstance>), ConsentInstance ccpaConsentInstance = default(ConsentInstance))
        {
            GdprConsentState = gdprConsentState ?? new Dictionary<string, ConsentInstance>();
            if (ccpaConsentInstance != null)
            {
                Ccpa = ccpaConsentInstance;
            }
        }
        
        /// <summary>
        /// Gets the GDPR consent instance dictionary
        /// </summary>
        [DataMember(Name="gdpr", EmitDefaultValue=false)]
        public Dictionary<string, ConsentInstance> GdprConsentState { get; set; }

        
        [DataMember(Name = "ccpa", EmitDefaultValue = false)]
        internal Dictionary<string, ConsentInstance> CcpaConsentState { get; set; }

        /// <summary>
        /// Gets or sets the CCPA consent instance
        /// </summary>
        public ConsentInstance Ccpa
        {
            get
            {
                if (CcpaConsentState != null && CcpaConsentState.Count == 1)
                {
                    return CcpaConsentState[CCPA_KEY];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                CcpaConsentState = new Dictionary<string, ConsentInstance>()
                {
                    { CCPA_KEY, value }
                };
            }
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentState {\n");
            sb.Append("  Gdpr: ").Append(GdprConsentState).Append("\n");
            sb.Append("  Ccpa: ").Append(CcpaConsentState).Append("\n");
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
                    this.GdprConsentState == input.GdprConsentState ||
                    (this.GdprConsentState != null &&
                    this.GdprConsentState.Equals(input.GdprConsentState))
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
                if (this.GdprConsentState != null)
                    hashCode = hashCode * 59 + this.GdprConsentState.GetHashCode();
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
