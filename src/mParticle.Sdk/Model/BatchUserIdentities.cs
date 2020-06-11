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
    /// BatchUserIdentities
    /// </summary>
    [DataContract]
    public partial class BatchUserIdentities :  IEquatable<BatchUserIdentities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUserIdentities" /> class.
        /// </summary>
        /// <param name="other">other.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="facebook">facebook.</param>
        /// <param name="twitter">twitter.</param>
        /// <param name="google">google.</param>
        /// <param name="microsoft">microsoft.</param>
        /// <param name="yahoo">yahoo.</param>
        /// <param name="email">email.</param>
        /// <param name="alias">alias.</param>
        /// <param name="facebookCustomAudienceId">facebookCustomAudienceId.</param>
        /// <param name="otherId2">otherId2.</param>
        /// <param name="otherId3">otherId3.</param>
        /// <param name="otherId4">otherId4.</param>
        /// <param name="otherId5">otherId5.</param>
        /// <param name="otherId6">otherId6.</param>
        /// <param name="otherId7">otherId7.</param>
        /// <param name="otherId8">otherId8.</param>
        /// <param name="otherId9">otherId9.</param>
        /// <param name="otherId10">otherId10.</param>
        /// <param name="mobileNumber">mobileNumber.</param>
        /// <param name="phoneNumber2">phoneNumber2.</param>
        /// <param name="phoneNumber3">phoneNumber3.</param>
        public BatchUserIdentities(string other = default(string), string customerId = default(string), string facebook = default(string), string twitter = default(string), string google = default(string), string microsoft = default(string), string yahoo = default(string), string email = default(string), string alias = default(string), string facebookCustomAudienceId = default(string), string otherId2 = default(string), string otherId3 = default(string), string otherId4 = default(string), string otherId5 = default(string), string otherId6 = default(string), string otherId7 = default(string), string otherId8 = default(string), string otherId9 = default(string), string otherId10 = default(string), string mobileNumber = default(string), string phoneNumber2 = default(string), string phoneNumber3 = default(string))
        {
            this.Other = other;
            this.CustomerId = customerId;
            this.Facebook = facebook;
            this.Twitter = twitter;
            this.Google = google;
            this.Microsoft = microsoft;
            this.Yahoo = yahoo;
            this.Email = email;
            this.Alias = alias;
            this.FacebookCustomAudienceId = facebookCustomAudienceId;
            this.OtherId2 = otherId2;
            this.OtherId3 = otherId3;
            this.OtherId4 = otherId4;
            this.OtherId5 = otherId5;
            this.OtherId6 = otherId6;
            this.OtherId7 = otherId7;
            this.OtherId8 = otherId8;
            this.OtherId9 = otherId9;
            this.OtherId10 = otherId10;
            this.MobileNumber = mobileNumber;
            this.PhoneNumber2 = phoneNumber2;
            this.PhoneNumber3 = phoneNumber3;
        }
        
        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=false)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Facebook
        /// </summary>
        [DataMember(Name="facebook", EmitDefaultValue=false)]
        public string Facebook { get; set; }

        /// <summary>
        /// Gets or Sets Twitter
        /// </summary>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public string Twitter { get; set; }

        /// <summary>
        /// Gets or Sets Google
        /// </summary>
        [DataMember(Name="google", EmitDefaultValue=false)]
        public string Google { get; set; }

        /// <summary>
        /// Gets or Sets Microsoft
        /// </summary>
        [DataMember(Name="microsoft", EmitDefaultValue=false)]
        public string Microsoft { get; set; }

        /// <summary>
        /// Gets or Sets Yahoo
        /// </summary>
        [DataMember(Name="yahoo", EmitDefaultValue=false)]
        public string Yahoo { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets FacebookCustomAudienceId
        /// </summary>
        [DataMember(Name="facebook_custom_audience_id", EmitDefaultValue=false)]
        public string FacebookCustomAudienceId { get; set; }

        /// <summary>
        /// Gets or Sets OtherId2
        /// </summary>
        [DataMember(Name="other_id_2", EmitDefaultValue=false)]
        public string OtherId2 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId3
        /// </summary>
        [DataMember(Name="other_id_3", EmitDefaultValue=false)]
        public string OtherId3 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId4
        /// </summary>
        [DataMember(Name="other_id_4", EmitDefaultValue=false)]
        public string OtherId4 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId5
        /// </summary>
        [DataMember(Name="other_id_5", EmitDefaultValue=false)]
        public string OtherId5 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId6
        /// </summary>
        [DataMember(Name="other_id_6", EmitDefaultValue=false)]
        public string OtherId6 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId7
        /// </summary>
        [DataMember(Name="other_id_7", EmitDefaultValue=false)]
        public string OtherId7 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId8
        /// </summary>
        [DataMember(Name="other_id_8", EmitDefaultValue=false)]
        public string OtherId8 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId9
        /// </summary>
        [DataMember(Name="other_id_9", EmitDefaultValue=false)]
        public string OtherId9 { get; set; }

        /// <summary>
        /// Gets or Sets OtherId10
        /// </summary>
        [DataMember(Name="other_id_10", EmitDefaultValue=false)]
        public string OtherId10 { get; set; }

        /// <summary>
        /// Gets or Sets MobileNumber
        /// </summary>
        [DataMember(Name="mobile_number", EmitDefaultValue=false)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber2
        /// </summary>
        [DataMember(Name="phone_number_2", EmitDefaultValue=false)]
        public string PhoneNumber2 { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber3
        /// </summary>
        [DataMember(Name="phone_number_3", EmitDefaultValue=false)]
        public string PhoneNumber3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUserIdentities {\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Facebook: ").Append(Facebook).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Google: ").Append(Google).Append("\n");
            sb.Append("  Microsoft: ").Append(Microsoft).Append("\n");
            sb.Append("  Yahoo: ").Append(Yahoo).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  FacebookCustomAudienceId: ").Append(FacebookCustomAudienceId).Append("\n");
            sb.Append("  OtherId2: ").Append(OtherId2).Append("\n");
            sb.Append("  OtherId3: ").Append(OtherId3).Append("\n");
            sb.Append("  OtherId4: ").Append(OtherId4).Append("\n");
            sb.Append("  OtherId5: ").Append(OtherId5).Append("\n");
            sb.Append("  OtherId6: ").Append(OtherId6).Append("\n");
            sb.Append("  OtherId7: ").Append(OtherId7).Append("\n");
            sb.Append("  OtherId8: ").Append(OtherId8).Append("\n");
            sb.Append("  OtherId9: ").Append(OtherId9).Append("\n");
            sb.Append("  OtherId10: ").Append(OtherId10).Append("\n");
            sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
            sb.Append("  PhoneNumber2: ").Append(PhoneNumber2).Append("\n");
            sb.Append("  PhoneNumber3: ").Append(PhoneNumber3).Append("\n");
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
            return this.Equals(input as BatchUserIdentities);
        }

        /// <summary>
        /// Returns true if BatchUserIdentities instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchUserIdentities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUserIdentities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Other == input.Other ||
                    (this.Other != null &&
                    this.Other.Equals(input.Other))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Facebook == input.Facebook ||
                    (this.Facebook != null &&
                    this.Facebook.Equals(input.Facebook))
                ) && 
                (
                    this.Twitter == input.Twitter ||
                    (this.Twitter != null &&
                    this.Twitter.Equals(input.Twitter))
                ) && 
                (
                    this.Google == input.Google ||
                    (this.Google != null &&
                    this.Google.Equals(input.Google))
                ) && 
                (
                    this.Microsoft == input.Microsoft ||
                    (this.Microsoft != null &&
                    this.Microsoft.Equals(input.Microsoft))
                ) && 
                (
                    this.Yahoo == input.Yahoo ||
                    (this.Yahoo != null &&
                    this.Yahoo.Equals(input.Yahoo))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.FacebookCustomAudienceId == input.FacebookCustomAudienceId ||
                    (this.FacebookCustomAudienceId != null &&
                    this.FacebookCustomAudienceId.Equals(input.FacebookCustomAudienceId))
                ) && 
                (
                    this.OtherId2 == input.OtherId2 ||
                    (this.OtherId2 != null &&
                    this.OtherId2.Equals(input.OtherId2))
                ) && 
                (
                    this.OtherId3 == input.OtherId3 ||
                    (this.OtherId3 != null &&
                    this.OtherId3.Equals(input.OtherId3))
                ) && 
                (
                    this.OtherId4 == input.OtherId4 ||
                    (this.OtherId4 != null &&
                    this.OtherId4.Equals(input.OtherId4))
                ) && 
                (
                    this.OtherId5 == input.OtherId5 ||
                    (this.OtherId5 != null &&
                    this.OtherId5.Equals(input.OtherId5))
                ) && 
                (
                    this.OtherId6 == input.OtherId6 ||
                    (this.OtherId6 != null &&
                    this.OtherId6.Equals(input.OtherId6))
                ) && 
                (
                    this.OtherId7 == input.OtherId7 ||
                    (this.OtherId7 != null &&
                    this.OtherId7.Equals(input.OtherId7))
                ) && 
                (
                    this.OtherId8 == input.OtherId8 ||
                    (this.OtherId8 != null &&
                    this.OtherId8.Equals(input.OtherId8))
                ) && 
                (
                    this.OtherId9 == input.OtherId9 ||
                    (this.OtherId9 != null &&
                    this.OtherId9.Equals(input.OtherId9))
                ) && 
                (
                    this.OtherId10 == input.OtherId10 ||
                    (this.OtherId10 != null &&
                    this.OtherId10.Equals(input.OtherId10))
                ) && 
                (
                    this.MobileNumber == input.MobileNumber ||
                    (this.MobileNumber != null &&
                    this.MobileNumber.Equals(input.MobileNumber))
                ) && 
                (
                    this.PhoneNumber2 == input.PhoneNumber2 ||
                    (this.PhoneNumber2 != null &&
                    this.PhoneNumber2.Equals(input.PhoneNumber2))
                ) && 
                (
                    this.PhoneNumber3 == input.PhoneNumber3 ||
                    (this.PhoneNumber3 != null &&
                    this.PhoneNumber3.Equals(input.PhoneNumber3))
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
                if (this.Other != null)
                    hashCode = hashCode * 59 + this.Other.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Facebook != null)
                    hashCode = hashCode * 59 + this.Facebook.GetHashCode();
                if (this.Twitter != null)
                    hashCode = hashCode * 59 + this.Twitter.GetHashCode();
                if (this.Google != null)
                    hashCode = hashCode * 59 + this.Google.GetHashCode();
                if (this.Microsoft != null)
                    hashCode = hashCode * 59 + this.Microsoft.GetHashCode();
                if (this.Yahoo != null)
                    hashCode = hashCode * 59 + this.Yahoo.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.FacebookCustomAudienceId != null)
                    hashCode = hashCode * 59 + this.FacebookCustomAudienceId.GetHashCode();
                if (this.OtherId2 != null)
                    hashCode = hashCode * 59 + this.OtherId2.GetHashCode();
                if (this.OtherId3 != null)
                    hashCode = hashCode * 59 + this.OtherId3.GetHashCode();
                if (this.OtherId4 != null)
                    hashCode = hashCode * 59 + this.OtherId4.GetHashCode();
                if (this.OtherId5 != null)
                    hashCode = hashCode * 59 + this.OtherId5.GetHashCode();
                if (this.OtherId6 != null)
                    hashCode = hashCode * 59 + this.OtherId6.GetHashCode();
                if (this.OtherId7 != null)
                    hashCode = hashCode * 59 + this.OtherId7.GetHashCode();
                if (this.OtherId8 != null)
                    hashCode = hashCode * 59 + this.OtherId8.GetHashCode();
                if (this.OtherId9 != null)
                    hashCode = hashCode * 59 + this.OtherId9.GetHashCode();
                if (this.OtherId10 != null)
                    hashCode = hashCode * 59 + this.OtherId10.GetHashCode();
                if (this.MobileNumber != null)
                    hashCode = hashCode * 59 + this.MobileNumber.GetHashCode();
                if (this.PhoneNumber2 != null)
                    hashCode = hashCode * 59 + this.PhoneNumber2.GetHashCode();
                if (this.PhoneNumber3 != null)
                    hashCode = hashCode * 59 + this.PhoneNumber3.GetHashCode();
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
