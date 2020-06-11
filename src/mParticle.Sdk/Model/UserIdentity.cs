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
    /// UserIdentity
    /// </summary>
    [DataContract]
    public partial class UserIdentity :  IEquatable<UserIdentity>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets IdentityType
        /// </summary>
        [DataMember(Name="identity_type", EmitDefaultValue=false)]
        public IdentityType IdentityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserIdentity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIdentity" /> class.
        /// </summary>
        /// <param name="identityType">identityType (required).</param>
        /// <param name="identity">identity (required).</param>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs (required).</param>
        /// <param name="createdThisBatch">createdThisBatch (required).</param>
        public UserIdentity(IdentityType identityType = default(IdentityType), string identity = default(string), int timestampUnixtimeMs = default(int), bool createdThisBatch = default(bool))
        {
            this.IdentityType = identityType;
            // to ensure "identity" is required (not null)
            this.Identity = identity ?? throw new ArgumentNullException("identity is a required property for UserIdentity and cannot be null");
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            this.CreatedThisBatch = createdThisBatch;
        }
        
        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public string Identity { get; set; }

        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public int TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets CreatedThisBatch
        /// </summary>
        [DataMember(Name="created_this_batch", EmitDefaultValue=false)]
        public bool CreatedThisBatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserIdentity {\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  CreatedThisBatch: ").Append(CreatedThisBatch).Append("\n");
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
            return this.Equals(input as UserIdentity);
        }

        /// <summary>
        /// Returns true if UserIdentity instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityType == input.IdentityType ||
                    this.IdentityType.Equals(input.IdentityType)
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.CreatedThisBatch == input.CreatedThisBatch ||
                    this.CreatedThisBatch.Equals(input.CreatedThisBatch)
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
                hashCode = hashCode * 59 + this.IdentityType.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedThisBatch.GetHashCode();
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
