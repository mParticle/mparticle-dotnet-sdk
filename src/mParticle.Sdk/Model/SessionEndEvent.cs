using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// SessionEndEvent
    /// </summary>
    [DataContract]
    public partial class SessionEndEvent : BaseEvent, IEquatable<SessionEndEvent>, IValidatableObject
    {
       
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEndEvent" /> class.
        /// </summary>
        public SessionEndEvent(): base(EventTypeEnum.Sessionend)
        {}

        /// <summary>
        /// Gets or Sets SessionDurationMs
        /// </summary>
        [DataMember(Name = "session_duration_ms", EmitDefaultValue = false)]
        public int SessionDurationMs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionEndEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  SessionDurationMs: ").Append(SessionDurationMs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionEndEvent);
        }

        /// <summary>
        /// Returns true if SessionEndEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionEndEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionEndEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) && (
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
                int hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.SessionDurationMs.GetHashCode();
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
