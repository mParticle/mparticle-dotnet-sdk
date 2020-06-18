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
    /// BatchContext
    /// </summary>
    [DataContract]
    public partial class BatchContext :  IEquatable<BatchContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchContext" /> class.
        /// </summary>
        /// <param name="dataPlan">dataPlan.</param>
        public BatchContext(DataPlanContext dataPlan = default(DataPlanContext))
        {
            this.DataPlan = dataPlan;
        }
        
        /// <summary>
        /// Gets or Sets DataPlan
        /// </summary>
        [DataMember(Name="data_plan", EmitDefaultValue=false)]
        public DataPlanContext DataPlan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchContext {\n");
            sb.Append("  DataPlan: ").Append(DataPlan).Append("\n");
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
            return this.Equals(input as BatchContext);
        }

        /// <summary>
        /// Returns true if BatchContext instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataPlan == input.DataPlan ||
                    (this.DataPlan != null &&
                    this.DataPlan.Equals(input.DataPlan))
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
                if (this.DataPlan != null)
                    hashCode = hashCode * 59 + this.DataPlan.GetHashCode();
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
