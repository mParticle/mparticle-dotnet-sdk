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
    /// GDPRConsentState
    /// </summary>
    [DataContract]
    public partial class GDPRConsentState :  IEquatable<GDPRConsentState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRConsentState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GDPRConsentState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GDPRConsentState" /> class.
        /// </summary>
        /// <param name="regulation">regulation (required).</param>
        /// <param name="document">document (required).</param>
        /// <param name="consented">consented (required).</param>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="hardwareId">hardwareId (required).</param>
        public GDPRConsentState(string regulation = default(string), string document = default(string), bool consented = default(bool), int timestampUnixtimeMs = default(int), string location = default(string), string hardwareId = default(string))
        {
            // to ensure "regulation" is required (not null)
            this.Regulation = regulation ?? throw new ArgumentNullException("regulation is a required property for GDPRConsentState and cannot be null");
            // to ensure "document" is required (not null)
            this.Document = document ?? throw new ArgumentNullException("document is a required property for GDPRConsentState and cannot be null");
            this.Consented = consented;
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for GDPRConsentState and cannot be null");
            // to ensure "hardwareId" is required (not null)
            this.HardwareId = hardwareId ?? throw new ArgumentNullException("hardwareId is a required property for GDPRConsentState and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Regulation
        /// </summary>
        [DataMember(Name="regulation", EmitDefaultValue=false)]
        public string Regulation { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public string Document { get; set; }

        /// <summary>
        /// Gets or Sets Consented
        /// </summary>
        [DataMember(Name="consented", EmitDefaultValue=false)]
        public bool Consented { get; set; }

        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public int TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets HardwareId
        /// </summary>
        [DataMember(Name="hardware_id", EmitDefaultValue=false)]
        public string HardwareId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GDPRConsentState {\n");
            sb.Append("  Regulation: ").Append(Regulation).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Consented: ").Append(Consented).Append("\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  HardwareId: ").Append(HardwareId).Append("\n");
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
            return this.Equals(input as GDPRConsentState);
        }

        /// <summary>
        /// Returns true if GDPRConsentState instances are equal
        /// </summary>
        /// <param name="input">Instance of GDPRConsentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GDPRConsentState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Regulation == input.Regulation ||
                    (this.Regulation != null &&
                    this.Regulation.Equals(input.Regulation))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Consented == input.Consented ||
                    this.Consented.Equals(input.Consented)
                ) && 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.HardwareId == input.HardwareId ||
                    (this.HardwareId != null &&
                    this.HardwareId.Equals(input.HardwareId))
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
                if (this.Regulation != null)
                    hashCode = hashCode * 59 + this.Regulation.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                hashCode = hashCode * 59 + this.Consented.GetHashCode();
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.HardwareId != null)
                    hashCode = hashCode * 59 + this.HardwareId.GetHashCode();
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
