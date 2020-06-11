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
    /// ApplicationInformation
    /// </summary>
    [DataContract]
    public partial class ApplicationInformation :  IEquatable<ApplicationInformation>, IValidatableObject
    {
        /// <summary>
        /// Defines Os
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OsEnum
        {
            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum IOS for value: IOS
            /// </summary>
            [EnumMember(Value = "IOS")]
            IOS = 2,

            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 3,

            /// <summary>
            /// Enum WindowsPhone for value: WindowsPhone
            /// </summary>
            [EnumMember(Value = "WindowsPhone")]
            WindowsPhone = 4,

            /// <summary>
            /// Enum MobileWeb for value: MobileWeb
            /// </summary>
            [EnumMember(Value = "MobileWeb")]
            MobileWeb = 5,

            /// <summary>
            /// Enum UnityIOS for value: UnityIOS
            /// </summary>
            [EnumMember(Value = "UnityIOS")]
            UnityIOS = 6,

            /// <summary>
            /// Enum UnityAndroid for value: UnityAndroid
            /// </summary>
            [EnumMember(Value = "UnityAndroid")]
            UnityAndroid = 7,

            /// <summary>
            /// Enum Desktop for value: Desktop
            /// </summary>
            [EnumMember(Value = "Desktop")]
            Desktop = 8,

            /// <summary>
            /// Enum TVOS for value: TVOS
            /// </summary>
            [EnumMember(Value = "TVOS")]
            TVOS = 9,

            /// <summary>
            /// Enum Roku for value: Roku
            /// </summary>
            [EnumMember(Value = "Roku")]
            Roku = 10,

            /// <summary>
            /// Enum OutOfBand for value: OutOfBand
            /// </summary>
            [EnumMember(Value = "OutOfBand")]
            OutOfBand = 11,

            /// <summary>
            /// Enum Alexa for value: Alexa
            /// </summary>
            [EnumMember(Value = "Alexa")]
            Alexa = 12,

            /// <summary>
            /// Enum SmartTV for value: SmartTV
            /// </summary>
            [EnumMember(Value = "SmartTV")]
            SmartTV = 13,

            /// <summary>
            /// Enum FireTV for value: FireTV
            /// </summary>
            [EnumMember(Value = "FireTV")]
            FireTV = 14,

            /// <summary>
            /// Enum Xbox for value: Xbox
            /// </summary>
            [EnumMember(Value = "Xbox")]
            Xbox = 15

        }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public OsEnum? Os { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInformation" /> class.
        /// </summary>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="applicationVersion">applicationVersion.</param>
        /// <param name="applicationBuildNumber">applicationBuildNumber.</param>
        /// <param name="installReferrer">installReferrer.</param>
        /// <param name="package">package.</param>
        /// <param name="os">os (default to OsEnum.Unknown).</param>
        /// <param name="appleSearchAdsAttributes">appleSearchAdsAttributes.</param>
        public ApplicationInformation(string applicationName = default(string), string applicationVersion = default(string), string applicationBuildNumber = default(string), string installReferrer = default(string), string package = default(string), OsEnum? os = OsEnum.Unknown, Dictionary<string, Dictionary<string, string>> appleSearchAdsAttributes = default(Dictionary<string, Dictionary<string, string>>))
        {
            this.ApplicationName = applicationName;
            this.ApplicationVersion = applicationVersion;
            this.ApplicationBuildNumber = applicationBuildNumber;
            this.InstallReferrer = installReferrer;
            this.Package = package;
            this.Os = os;
            this.AppleSearchAdsAttributes = appleSearchAdsAttributes;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="application_name", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationVersion
        /// </summary>
        [DataMember(Name="application_version", EmitDefaultValue=false)]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationBuildNumber
        /// </summary>
        [DataMember(Name="application_build_number", EmitDefaultValue=false)]
        public string ApplicationBuildNumber { get; set; }

        /// <summary>
        /// Gets or Sets InstallReferrer
        /// </summary>
        [DataMember(Name="install_referrer", EmitDefaultValue=false)]
        public string InstallReferrer { get; set; }

        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [DataMember(Name="package", EmitDefaultValue=false)]
        public string Package { get; set; }

        /// <summary>
        /// Gets or Sets AppleSearchAdsAttributes
        /// </summary>
        [DataMember(Name="apple_search_ads_attributes", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> AppleSearchAdsAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInformation {\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationVersion: ").Append(ApplicationVersion).Append("\n");
            sb.Append("  ApplicationBuildNumber: ").Append(ApplicationBuildNumber).Append("\n");
            sb.Append("  InstallReferrer: ").Append(InstallReferrer).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  AppleSearchAdsAttributes: ").Append(AppleSearchAdsAttributes).Append("\n");
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
            return this.Equals(input as ApplicationInformation);
        }

        /// <summary>
        /// Returns true if ApplicationInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.ApplicationVersion == input.ApplicationVersion ||
                    (this.ApplicationVersion != null &&
                    this.ApplicationVersion.Equals(input.ApplicationVersion))
                ) && 
                (
                    this.ApplicationBuildNumber == input.ApplicationBuildNumber ||
                    (this.ApplicationBuildNumber != null &&
                    this.ApplicationBuildNumber.Equals(input.ApplicationBuildNumber))
                ) && 
                (
                    this.InstallReferrer == input.InstallReferrer ||
                    (this.InstallReferrer != null &&
                    this.InstallReferrer.Equals(input.InstallReferrer))
                ) && 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
                ) && 
                (
                    this.Os == input.Os ||
                    this.Os.Equals(input.Os)
                ) && 
                (
                    this.AppleSearchAdsAttributes == input.AppleSearchAdsAttributes ||
                    this.AppleSearchAdsAttributes != null &&
                    input.AppleSearchAdsAttributes != null &&
                    this.AppleSearchAdsAttributes.SequenceEqual(input.AppleSearchAdsAttributes)
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
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationVersion != null)
                    hashCode = hashCode * 59 + this.ApplicationVersion.GetHashCode();
                if (this.ApplicationBuildNumber != null)
                    hashCode = hashCode * 59 + this.ApplicationBuildNumber.GetHashCode();
                if (this.InstallReferrer != null)
                    hashCode = hashCode * 59 + this.InstallReferrer.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.AppleSearchAdsAttributes != null)
                    hashCode = hashCode * 59 + this.AppleSearchAdsAttributes.GetHashCode();
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
