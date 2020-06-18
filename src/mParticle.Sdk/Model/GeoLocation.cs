using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// GeoLocation
    /// </summary>
    [DataContract]
    public partial class GeoLocation : IEquatable<GeoLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeoLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocation" /> class.
        /// </summary>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="accuracy">accuracy.</param>
        public GeoLocation(decimal latitude = default(decimal), decimal longitude = default(decimal), decimal accuracy = default(decimal))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Accuracy = accuracy;
        }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name= "latitude", EmitDefaultValue= false)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name= "longitude", EmitDefaultValue= false)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Accuracy
        /// </summary>
        [DataMember(Name= "accuracy", EmitDefaultValue= false)]
        public decimal Accuracy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocation {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
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
            return this.Equals(input as GeoLocation);
        }

        /// <summary>
        /// Returns true if GeoLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocation input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) &&
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) &&
                (
                    this.Accuracy == input.Accuracy ||
                    this.Accuracy.Equals(input.Accuracy)
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
                hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                hashCode = hashCode * 59 + this.Accuracy.GetHashCode();
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
