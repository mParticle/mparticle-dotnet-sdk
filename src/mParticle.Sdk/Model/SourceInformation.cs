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
    /// SourceInformation
    /// </summary>
    [DataContract]
    public partial class SourceInformation :  IEquatable<SourceInformation>, IValidatableObject
    {
        /// <summary>
        /// Defines Channel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Native for value: native
            /// </summary>
            [EnumMember(Value = "native")]
            Native = 1,

            /// <summary>
            /// Enum Javascript for value: javascript
            /// </summary>
            [EnumMember(Value = "javascript")]
            Javascript = 2,

            /// <summary>
            /// Enum Pixel for value: pixel
            /// </summary>
            [EnumMember(Value = "pixel")]
            Pixel = 3,

            /// <summary>
            /// Enum Desktop for value: desktop
            /// </summary>
            [EnumMember(Value = "desktop")]
            Desktop = 4,

            /// <summary>
            /// Enum Partner for value: partner
            /// </summary>
            [EnumMember(Value = "partner")]
            Partner = 5,

            /// <summary>
            /// Enum Servertoserver for value: server_to_server
            /// </summary>
            [EnumMember(Value = "server_to_server")]
            Servertoserver = 6

        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInformation" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="partner">partner.</param>
        /// <param name="replayRequestId">replayRequestId.</param>
        /// <param name="replayJobId">replayJobId.</param>
        /// <param name="isHistorical">isHistorical.</param>
        public SourceInformation(ChannelEnum? channel = default(ChannelEnum?), string partner = default(string), string replayRequestId = default(string), string replayJobId = default(string), bool isHistorical = default(bool))
        {
            this.Channel = channel;
            this.Partner = partner;
            this.ReplayRequestId = replayRequestId;
            this.ReplayJobId = replayJobId;
            this.IsHistorical = isHistorical;
        }
        
        /// <summary>
        /// Gets or Sets Partner
        /// </summary>
        [DataMember(Name="partner", EmitDefaultValue=false)]
        public string Partner { get; set; }

        /// <summary>
        /// Gets or Sets ReplayRequestId
        /// </summary>
        [DataMember(Name="replay_request_id", EmitDefaultValue=false)]
        public string ReplayRequestId { get; set; }

        /// <summary>
        /// Gets or Sets ReplayJobId
        /// </summary>
        [DataMember(Name="replay_job_id", EmitDefaultValue=false)]
        public string ReplayJobId { get; set; }

        /// <summary>
        /// Gets or Sets IsHistorical
        /// </summary>
        [DataMember(Name="is_historical", EmitDefaultValue=false)]
        public bool IsHistorical { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceInformation {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Partner: ").Append(Partner).Append("\n");
            sb.Append("  ReplayRequestId: ").Append(ReplayRequestId).Append("\n");
            sb.Append("  ReplayJobId: ").Append(ReplayJobId).Append("\n");
            sb.Append("  IsHistorical: ").Append(IsHistorical).Append("\n");
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
            return this.Equals(input as SourceInformation);
        }

        /// <summary>
        /// Returns true if SourceInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Channel == input.Channel ||
                    this.Channel.Equals(input.Channel)
                ) && 
                (
                    this.Partner == input.Partner ||
                    (this.Partner != null &&
                    this.Partner.Equals(input.Partner))
                ) && 
                (
                    this.ReplayRequestId == input.ReplayRequestId ||
                    (this.ReplayRequestId != null &&
                    this.ReplayRequestId.Equals(input.ReplayRequestId))
                ) && 
                (
                    this.ReplayJobId == input.ReplayJobId ||
                    (this.ReplayJobId != null &&
                    this.ReplayJobId.Equals(input.ReplayJobId))
                ) && 
                (
                    this.IsHistorical == input.IsHistorical ||
                    this.IsHistorical.Equals(input.IsHistorical)
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
                hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Partner != null)
                    hashCode = hashCode * 59 + this.Partner.GetHashCode();
                if (this.ReplayRequestId != null)
                    hashCode = hashCode * 59 + this.ReplayRequestId.GetHashCode();
                if (this.ReplayJobId != null)
                    hashCode = hashCode * 59 + this.ReplayJobId.GetHashCode();
                hashCode = hashCode * 59 + this.IsHistorical.GetHashCode();
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
