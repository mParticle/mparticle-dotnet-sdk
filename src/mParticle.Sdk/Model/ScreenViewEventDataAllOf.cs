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
    /// ScreenViewEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class ScreenViewEventDataAllOf :  IEquatable<ScreenViewEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenViewEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScreenViewEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenViewEventDataAllOf" /> class.
        /// </summary>
        /// <param name="screenName">screenName (required).</param>
        /// <param name="activityType">activityType.</param>
        /// <param name="customFlags">customFlags.</param>
        public ScreenViewEventDataAllOf(string screenName = default(string), string activityType = default(string), Dictionary<string, string> customFlags = default(Dictionary<string, string>))
        {
            // to ensure "screenName" is required (not null)
            this.ScreenName = screenName ?? throw new ArgumentNullException("screenName is a required property for ScreenViewEventDataAllOf and cannot be null");
            this.ActivityType = activityType;
            this.CustomFlags = customFlags;
        }
        
        /// <summary>
        /// Gets or Sets ScreenName
        /// </summary>
        [DataMember(Name="screen_name", EmitDefaultValue=false)]
        public string ScreenName { get; set; }

        /// <summary>
        /// Gets or Sets ActivityType
        /// </summary>
        [DataMember(Name="activity_type", EmitDefaultValue=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// Gets or Sets CustomFlags
        /// </summary>
        [DataMember(Name="custom_flags", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScreenViewEventDataAllOf {\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
            sb.Append("  CustomFlags: ").Append(CustomFlags).Append("\n");
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
            return this.Equals(input as ScreenViewEventDataAllOf);
        }

        /// <summary>
        /// Returns true if ScreenViewEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ScreenViewEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScreenViewEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScreenName == input.ScreenName ||
                    (this.ScreenName != null &&
                    this.ScreenName.Equals(input.ScreenName))
                ) && 
                (
                    this.ActivityType == input.ActivityType ||
                    (this.ActivityType != null &&
                    this.ActivityType.Equals(input.ActivityType))
                ) && 
                (
                    this.CustomFlags == input.CustomFlags ||
                    this.CustomFlags != null &&
                    input.CustomFlags != null &&
                    this.CustomFlags.SequenceEqual(input.CustomFlags)
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
                if (this.ScreenName != null)
                    hashCode = hashCode * 59 + this.ScreenName.GetHashCode();
                if (this.ActivityType != null)
                    hashCode = hashCode * 59 + this.ActivityType.GetHashCode();
                if (this.CustomFlags != null)
                    hashCode = hashCode * 59 + this.CustomFlags.GetHashCode();
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
