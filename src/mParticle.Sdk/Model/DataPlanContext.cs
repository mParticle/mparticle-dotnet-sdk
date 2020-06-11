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
    /// DataPlanContext
    /// </summary>
    [DataContract]
    public partial class DataPlanContext :  IEquatable<DataPlanContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanContext" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataPlanContext() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanContext" /> class.
        /// </summary>
        /// <param name="planId">planId (required).</param>
        /// <param name="planVersion">planVersion.</param>
        public DataPlanContext(string planId = default(string), int planVersion = default(int))
        {
            // to ensure "planId" is required (not null)
            this.PlanId = planId ?? throw new ArgumentNullException("planId is a required property for DataPlanContext and cannot be null");
            this.PlanVersion = planVersion;
        }
        
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or Sets PlanVersion
        /// </summary>
        [DataMember(Name="plan_version", EmitDefaultValue=false)]
        public int PlanVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataPlanContext {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanVersion: ").Append(PlanVersion).Append("\n");
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
            return this.Equals(input as DataPlanContext);
        }

        /// <summary>
        /// Returns true if DataPlanContext instances are equal
        /// </summary>
        /// <param name="input">Instance of DataPlanContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataPlanContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.PlanVersion == input.PlanVersion ||
                    this.PlanVersion.Equals(input.PlanVersion)
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
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                hashCode = hashCode * 59 + this.PlanVersion.GetHashCode();
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
