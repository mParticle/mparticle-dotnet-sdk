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
    /// BreadcrumbEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class BreadcrumbEventDataAllOf :  IEquatable<BreadcrumbEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BreadcrumbEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbEventDataAllOf" /> class.
        /// </summary>
        /// <param name="sessionNumber">sessionNumber.</param>
        /// <param name="label">label (required).</param>
        public BreadcrumbEventDataAllOf(int sessionNumber = default(int), string label = default(string))
        {
            // to ensure "label" is required (not null)
            this.Label = label ?? throw new ArgumentNullException("label is a required property for BreadcrumbEventDataAllOf and cannot be null");
            this.SessionNumber = sessionNumber;
        }
        
        /// <summary>
        /// Gets or Sets SessionNumber
        /// </summary>
        [DataMember(Name="session_number", EmitDefaultValue=false)]
        public int SessionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreadcrumbEventDataAllOf {\n");
            sb.Append("  SessionNumber: ").Append(SessionNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as BreadcrumbEventDataAllOf);
        }

        /// <summary>
        /// Returns true if BreadcrumbEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BreadcrumbEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreadcrumbEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionNumber == input.SessionNumber ||
                    this.SessionNumber.Equals(input.SessionNumber)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                hashCode = hashCode * 59 + this.SessionNumber.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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
