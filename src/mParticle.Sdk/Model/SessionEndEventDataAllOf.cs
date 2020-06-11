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
    /// SessionEndEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class SessionEndEventDataAllOf :  IEquatable<SessionEndEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEndEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionEndEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEndEventDataAllOf" /> class.
        /// </summary>
        /// <param name="sessionDurationMs">sessionDurationMs (required).</param>
        public SessionEndEventDataAllOf(int sessionDurationMs = default(int))
        {
            this.SessionDurationMs = sessionDurationMs;
        }
        
        /// <summary>
        /// Gets or Sets SessionDurationMs
        /// </summary>
        [DataMember(Name="session_duration_ms", EmitDefaultValue=false)]
        public int SessionDurationMs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionEndEventDataAllOf {\n");
            sb.Append("  SessionDurationMs: ").Append(SessionDurationMs).Append("\n");
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
            return this.Equals(input as SessionEndEventDataAllOf);
        }

        /// <summary>
        /// Returns true if SessionEndEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionEndEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionEndEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionDurationMs == input.SessionDurationMs ||
                    this.SessionDurationMs.Equals(input.SessionDurationMs)
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
                hashCode = hashCode * 59 + this.SessionDurationMs.GetHashCode();
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
