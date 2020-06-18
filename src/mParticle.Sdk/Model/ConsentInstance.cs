using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// GDPRConsentState
    /// </summary>
    [DataContract]
    public partial class ConsentInstance : IEquatable<ConsentInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentInstance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsentInstance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentInstance" /> class.
        /// </summary>
        /// <param name="regulation">regulation (required).</param>
        /// <param name="document">document (required).</param>
        /// <param name="consented">consented (required).</param>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="hardwareId">hardwareId (required).</param>
        public ConsentInstance(bool consented, string regulation = default(string), string document = default(string), long? timestampUnixtimeMs = null, string location = default(string), string hardwareId = default(string))
        {
            this.Consented = consented;
            this.Regulation = regulation;
            this.Document = document;
            this.TimestampUnixtimeMs = timestampUnixtimeMs ?? DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            this.Location = location;
            this.HardwareId = hardwareId;
        }

        /// <summary>
        /// Gets or Sets Regulation
        /// </summary>
        [DataMember(Name= "regulation", EmitDefaultValue= false)]
        public string Regulation { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name= "document", EmitDefaultValue= false)]
        public string Document { get; set; }

        /// <summary>
        /// Gets or Sets Consented
        /// </summary>
        [DataMember(Name= "consented", EmitDefaultValue= true)]
        public bool Consented { get; set; }

        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name= "timestamp_unixtime_ms", EmitDefaultValue= false)]
        public long TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name= "location", EmitDefaultValue= false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets HardwareId
        /// </summary>
        [DataMember(Name= "hardware_id", EmitDefaultValue= false)]
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
            return this.Equals(input as ConsentInstance);
        }

        /// <summary>
        /// Returns true if GDPRConsentState instances are equal
        /// </summary>
        /// <param name="input">Instance of GDPRConsentState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentInstance input)
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
