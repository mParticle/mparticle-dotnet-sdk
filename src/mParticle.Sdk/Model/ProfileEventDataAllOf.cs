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
    /// ProfileEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class ProfileEventDataAllOf :  IEquatable<ProfileEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Defines ProfileEventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProfileEventTypeEnum
        {
            /// <summary>
            /// Enum Signup for value: signup
            /// </summary>
            [EnumMember(Value = "signup")]
            Signup = 1,

            /// <summary>
            /// Enum Login for value: login
            /// </summary>
            [EnumMember(Value = "login")]
            Login = 2,

            /// <summary>
            /// Enum Logout for value: logout
            /// </summary>
            [EnumMember(Value = "logout")]
            Logout = 3,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 4,

            /// <summary>
            /// Enum Delete for value: delete
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete = 5

        }

        /// <summary>
        /// Gets or Sets ProfileEventType
        /// </summary>
        [DataMember(Name="profile_event_type", EmitDefaultValue=false)]
        public ProfileEventTypeEnum ProfileEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfileEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileEventDataAllOf" /> class.
        /// </summary>
        /// <param name="previousMpid">previousMpid (required).</param>
        /// <param name="currentMpid">currentMpid (required).</param>
        /// <param name="profileEventType">profileEventType (required).</param>
        public ProfileEventDataAllOf(int previousMpid = default(int), int currentMpid = default(int), ProfileEventTypeEnum profileEventType = default(ProfileEventTypeEnum))
        {
            this.PreviousMpid = previousMpid;
            this.CurrentMpid = currentMpid;
            this.ProfileEventType = profileEventType;
        }
        
        /// <summary>
        /// Gets or Sets PreviousMpid
        /// </summary>
        [DataMember(Name="previous_mpid", EmitDefaultValue=false)]
        public int PreviousMpid { get; set; }

        /// <summary>
        /// Gets or Sets CurrentMpid
        /// </summary>
        [DataMember(Name="current_mpid", EmitDefaultValue=false)]
        public int CurrentMpid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileEventDataAllOf {\n");
            sb.Append("  PreviousMpid: ").Append(PreviousMpid).Append("\n");
            sb.Append("  CurrentMpid: ").Append(CurrentMpid).Append("\n");
            sb.Append("  ProfileEventType: ").Append(ProfileEventType).Append("\n");
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
            return this.Equals(input as ProfileEventDataAllOf);
        }

        /// <summary>
        /// Returns true if ProfileEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviousMpid == input.PreviousMpid ||
                    this.PreviousMpid.Equals(input.PreviousMpid)
                ) && 
                (
                    this.CurrentMpid == input.CurrentMpid ||
                    this.CurrentMpid.Equals(input.CurrentMpid)
                ) && 
                (
                    this.ProfileEventType == input.ProfileEventType ||
                    this.ProfileEventType.Equals(input.ProfileEventType)
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
                hashCode = hashCode * 59 + this.PreviousMpid.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentMpid.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileEventType.GetHashCode();
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
