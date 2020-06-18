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
using OpenAPIDateConverter = mParticle.Client.OpenAPIDateConverter;

namespace mParticle.Model
{
    /// <summary>
    /// AttributionInfo
    /// </summary>
    [DataContract]
    public partial class AttributionInfo :  IEquatable<AttributionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttributionInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributionInfo" /> class.
        /// </summary>
        /// <param name="serviceProvider">serviceProvider (required).</param>
        /// <param name="publisher">publisher (required).</param>
        /// <param name="campaign">campaign (required).</param>
        public AttributionInfo(string serviceProvider, string publisher, string campaign)
        {
            // to ensure "serviceProvider" is required (not null)
            this.ServiceProvider = serviceProvider ?? throw new ArgumentNullException("serviceProvider is a required property for AttributionInfo and cannot be null");
            // to ensure "publisher" is required (not null)
            this.Publisher = publisher ?? throw new ArgumentNullException("publisher is a required property for AttributionInfo and cannot be null");
            // to ensure "campaign" is required (not null)
            this.Campaign = campaign ?? throw new ArgumentNullException("campaign is a required property for AttributionInfo and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets ServiceProvider
        /// </summary>
        [DataMember(Name="service_provider", EmitDefaultValue=false)]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// Gets or Sets Publisher
        /// </summary>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public string Campaign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributionInfo {\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
            return this.Equals(input as AttributionInfo);
        }

        /// <summary>
        /// Returns true if AttributionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AttributionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributionInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceProvider == input.ServiceProvider ||
                    (this.ServiceProvider != null &&
                    this.ServiceProvider.Equals(input.ServiceProvider))
                ) && 
                (
                    this.Publisher == input.Publisher ||
                    (this.Publisher != null &&
                    this.Publisher.Equals(input.Publisher))
                ) && 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
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
                if (this.ServiceProvider != null)
                    hashCode = hashCode * 59 + this.ServiceProvider.GetHashCode();
                if (this.Publisher != null)
                    hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
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
