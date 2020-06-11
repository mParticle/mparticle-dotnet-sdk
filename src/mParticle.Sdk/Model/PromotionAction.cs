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
    /// PromotionAction
    /// </summary>
    [DataContract]
    public partial class PromotionAction :  IEquatable<PromotionAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum View for value: view
            /// </summary>
            [EnumMember(Value = "view")]
            View = 1,

            /// <summary>
            /// Enum Click for value: click
            /// </summary>
            [EnumMember(Value = "click")]
            Click = 2

        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PromotionAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionAction" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="promotions">promotions (required).</param>
        public PromotionAction(ActionEnum action = default(ActionEnum), Collection<Promotion> promotions = default(Collection<Promotion>))
        {
            this.Action = action;
            // to ensure "promotions" is required (not null)
            this.Promotions = promotions ?? throw new ArgumentNullException("promotions is a required property for PromotionAction and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name="promotions", EmitDefaultValue=false)]
        public Collection<Promotion> Promotions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromotionAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
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
            return this.Equals(input as PromotionAction);
        }

        /// <summary>
        /// Returns true if PromotionAction instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotionAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotionAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Promotions == input.Promotions ||
                    this.Promotions != null &&
                    input.Promotions != null &&
                    this.Promotions.SequenceEqual(input.Promotions)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Promotions != null)
                    hashCode = hashCode * 59 + this.Promotions.GetHashCode();
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
