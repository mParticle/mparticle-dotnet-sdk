using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// Promotion
    /// </summary>
    [DataContract]
    public partial class Promotion : IEquatable<Promotion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Promotion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Promotion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Promotion" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="creative">creative (required).</param>
        /// <param name="position">position (required).</param>
        public Promotion(string id, string name, string creative = default(string), string position = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Promotion and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Promotion and cannot be null");
            // to ensure "creative" is required (not null)
            this.Creative = creative;
            // to ensure "position" is required (not null)
            this.Position = position;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name= "id", EmitDefaultValue= false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name= "name", EmitDefaultValue= false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Creative
        /// </summary>
        [DataMember(Name= "creative", EmitDefaultValue= false)]
        public string Creative { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name= "position", EmitDefaultValue= false)]
        public string Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Promotion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Creative: ").Append(Creative).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as Promotion);
        }

        /// <summary>
        /// Returns true if Promotion instances are equal
        /// </summary>
        /// <param name="input">Instance of Promotion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Promotion input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Creative == input.Creative ||
                    (this.Creative != null &&
                    this.Creative.Equals(input.Creative))
                ) &&
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Creative != null)
                    hashCode = hashCode * 59 + this.Creative.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
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
