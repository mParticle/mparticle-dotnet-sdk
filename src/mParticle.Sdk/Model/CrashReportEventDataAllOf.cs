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
    /// CrashReportEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class CrashReportEventDataAllOf :  IEquatable<CrashReportEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashReportEventDataAllOf" /> class.
        /// </summary>
        /// <param name="breadcrumbs">breadcrumbs.</param>
        /// <param name="className">className.</param>
        /// <param name="severity">severity.</param>
        /// <param name="message">message.</param>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="exceptionHandled">exceptionHandled.</param>
        /// <param name="topmostContext">topmostContext.</param>
        /// <param name="plCrashReportFileBase64">plCrashReportFileBase64.</param>
        /// <param name="iosImageBaseAddress">iosImageBaseAddress.</param>
        /// <param name="iosImageSize">iosImageSize.</param>
        /// <param name="sessionNumber">sessionNumber.</param>
        public CrashReportEventDataAllOf(Collection<string> breadcrumbs = default(Collection<string>), string className = default(string), string severity = default(string), string message = default(string), string stackTrace = default(string), bool exceptionHandled = default(bool), string topmostContext = default(string), string plCrashReportFileBase64 = default(string), int iosImageBaseAddress = default(int), int iosImageSize = default(int), int sessionNumber = default(int))
        {
            this.Breadcrumbs = breadcrumbs;
            this.ClassName = className;
            this.Severity = severity;
            this.Message = message;
            this.StackTrace = stackTrace;
            this.ExceptionHandled = exceptionHandled;
            this.TopmostContext = topmostContext;
            this.PlCrashReportFileBase64 = plCrashReportFileBase64;
            this.IosImageBaseAddress = iosImageBaseAddress;
            this.IosImageSize = iosImageSize;
            this.SessionNumber = sessionNumber;
        }
        
        /// <summary>
        /// Gets or Sets Breadcrumbs
        /// </summary>
        [DataMember(Name="breadcrumbs", EmitDefaultValue=false)]
        public Collection<string> Breadcrumbs { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name="class_name", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name="stack_trace", EmitDefaultValue=false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionHandled
        /// </summary>
        [DataMember(Name="exception_handled", EmitDefaultValue=false)]
        public bool ExceptionHandled { get; set; }

        /// <summary>
        /// Gets or Sets TopmostContext
        /// </summary>
        [DataMember(Name="topmost_context", EmitDefaultValue=false)]
        public string TopmostContext { get; set; }

        /// <summary>
        /// Gets or Sets PlCrashReportFileBase64
        /// </summary>
        [DataMember(Name="pl_crash_report_file_base64", EmitDefaultValue=false)]
        public string PlCrashReportFileBase64 { get; set; }

        /// <summary>
        /// Gets or Sets IosImageBaseAddress
        /// </summary>
        [DataMember(Name="ios_image_base_address", EmitDefaultValue=false)]
        public int IosImageBaseAddress { get; set; }

        /// <summary>
        /// Gets or Sets IosImageSize
        /// </summary>
        [DataMember(Name="ios_image_size", EmitDefaultValue=false)]
        public int IosImageSize { get; set; }

        /// <summary>
        /// Gets or Sets SessionNumber
        /// </summary>
        [DataMember(Name="session_number", EmitDefaultValue=false)]
        public int SessionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashReportEventDataAllOf {\n");
            sb.Append("  Breadcrumbs: ").Append(Breadcrumbs).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
            sb.Append("  ExceptionHandled: ").Append(ExceptionHandled).Append("\n");
            sb.Append("  TopmostContext: ").Append(TopmostContext).Append("\n");
            sb.Append("  PlCrashReportFileBase64: ").Append(PlCrashReportFileBase64).Append("\n");
            sb.Append("  IosImageBaseAddress: ").Append(IosImageBaseAddress).Append("\n");
            sb.Append("  IosImageSize: ").Append(IosImageSize).Append("\n");
            sb.Append("  SessionNumber: ").Append(SessionNumber).Append("\n");
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
            return this.Equals(input as CrashReportEventDataAllOf);
        }

        /// <summary>
        /// Returns true if CrashReportEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashReportEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashReportEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Breadcrumbs == input.Breadcrumbs ||
                    this.Breadcrumbs != null &&
                    input.Breadcrumbs != null &&
                    this.Breadcrumbs.SequenceEqual(input.Breadcrumbs)
                ) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.StackTrace == input.StackTrace ||
                    (this.StackTrace != null &&
                    this.StackTrace.Equals(input.StackTrace))
                ) && 
                (
                    this.ExceptionHandled == input.ExceptionHandled ||
                    this.ExceptionHandled.Equals(input.ExceptionHandled)
                ) && 
                (
                    this.TopmostContext == input.TopmostContext ||
                    (this.TopmostContext != null &&
                    this.TopmostContext.Equals(input.TopmostContext))
                ) && 
                (
                    this.PlCrashReportFileBase64 == input.PlCrashReportFileBase64 ||
                    (this.PlCrashReportFileBase64 != null &&
                    this.PlCrashReportFileBase64.Equals(input.PlCrashReportFileBase64))
                ) && 
                (
                    this.IosImageBaseAddress == input.IosImageBaseAddress ||
                    this.IosImageBaseAddress.Equals(input.IosImageBaseAddress)
                ) && 
                (
                    this.IosImageSize == input.IosImageSize ||
                    this.IosImageSize.Equals(input.IosImageSize)
                ) && 
                (
                    this.SessionNumber == input.SessionNumber ||
                    this.SessionNumber.Equals(input.SessionNumber)
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
                if (this.Breadcrumbs != null)
                    hashCode = hashCode * 59 + this.Breadcrumbs.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.StackTrace != null)
                    hashCode = hashCode * 59 + this.StackTrace.GetHashCode();
                hashCode = hashCode * 59 + this.ExceptionHandled.GetHashCode();
                if (this.TopmostContext != null)
                    hashCode = hashCode * 59 + this.TopmostContext.GetHashCode();
                if (this.PlCrashReportFileBase64 != null)
                    hashCode = hashCode * 59 + this.PlCrashReportFileBase64.GetHashCode();
                hashCode = hashCode * 59 + this.IosImageBaseAddress.GetHashCode();
                hashCode = hashCode * 59 + this.IosImageSize.GetHashCode();
                hashCode = hashCode * 59 + this.SessionNumber.GetHashCode();
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
