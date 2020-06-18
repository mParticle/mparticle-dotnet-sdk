using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// SessionStartEvent
    /// </summary>
    [DataContract]
    public partial class SessionStartEvent : BaseEvent, IEquatable<SessionStartEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionStartEvent" /> class.
        /// </summary>
        public SessionStartEvent(): base(EventTypeEnum.Sessionstart)
        {}
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionStartEvent {\n");
            sb.Append(base.ToString());
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
            return this.Equals(input as SessionStartEvent);
        }

        /// <summary>
        /// Returns true if SessionStartEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionStartEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionStartEvent input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                return base.GetHashCode();
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
