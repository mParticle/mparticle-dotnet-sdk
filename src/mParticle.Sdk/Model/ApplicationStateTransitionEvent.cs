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
using EventTypeEnum = mParticle.Model.EventType;

namespace mParticle.Model
{
    /// <summary>
    /// ApplicationStateTransitionEvent
    /// </summary>
    [DataContract]
    public partial class ApplicationStateTransitionEvent : BaseEvent, IEquatable<ApplicationStateTransitionEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationStateTransitionEvent" /> class.
        /// </summary>
        public ApplicationStateTransitionEvent(): base(EventTypeEnum.Applicationstatetransition)
        {
        
        }

        /// <summary>
        /// Gets or Sets ApplicationTransitionType
        /// </summary>
        [DataMember(Name = "application_transition_type", EmitDefaultValue = false)]
        public ApplicationTransitionTypeEnum ApplicationTransitionType { get; set; }


        /// <summary>
        /// Gets or Sets SuccessfullyClosed
        /// </summary>
        [DataMember(Name = "successfully_closed", EmitDefaultValue = false)]
        public bool SuccessfullyClosed { get; set; }

        /// <summary>
        /// Gets or Sets IsFirstRun
        /// </summary>
        [DataMember(Name = "is_first_run", EmitDefaultValue = false)]
        public bool IsFirstRun { get; set; }

        /// <summary>
        /// Gets or Sets IsUpgrade
        /// </summary>
        [DataMember(Name = "is_upgrade", EmitDefaultValue = false)]
        public bool IsUpgrade { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationPayload
        /// </summary>
        [DataMember(Name = "push_notification_payload", EmitDefaultValue = false)]
        public string PushNotificationPayload { get; set; }

        /// <summary>
        /// Gets or Sets LaunchReferral
        /// </summary>
        [DataMember(Name = "launch_referral", EmitDefaultValue = false)]
        public string LaunchReferral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationStateTransitionEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  SuccessfullyClosed: ").Append(SuccessfullyClosed).Append("\n");
            sb.Append("  IsFirstRun: ").Append(IsFirstRun).Append("\n");
            sb.Append("  IsUpgrade: ").Append(IsUpgrade).Append("\n");
            sb.Append("  PushNotificationPayload: ").Append(PushNotificationPayload).Append("\n");
            sb.Append("  LaunchReferral: ").Append(LaunchReferral).Append("\n");
            sb.Append("  ApplicationTransitionType: ").Append(ApplicationTransitionType).Append("\n");
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
            return this.Equals(input as ApplicationStateTransitionEvent);
        }

        /// <summary>
        /// Returns true if ApplicationStateTransitionEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationStateTransitionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationStateTransitionEvent input)
        {
            if (input == null)
                return false;

            return
                base.Equals(input) &&
                (
                    this.SuccessfullyClosed == input.SuccessfullyClosed ||
                    this.SuccessfullyClosed.Equals(input.SuccessfullyClosed)
                ) &&
                (
                    this.IsFirstRun == input.IsFirstRun ||
                    this.IsFirstRun.Equals(input.IsFirstRun)
                ) &&
                (
                    this.IsUpgrade == input.IsUpgrade ||
                    this.IsUpgrade.Equals(input.IsUpgrade)
                ) &&
                (
                    this.PushNotificationPayload == input.PushNotificationPayload ||
                    (this.PushNotificationPayload != null &&
                    this.PushNotificationPayload.Equals(input.PushNotificationPayload))
                ) &&
                (
                    this.LaunchReferral == input.LaunchReferral ||
                    (this.LaunchReferral != null &&
                    this.LaunchReferral.Equals(input.LaunchReferral))
                ) &&
                (
                    this.ApplicationTransitionType == input.ApplicationTransitionType ||
                    this.ApplicationTransitionType.Equals(input.ApplicationTransitionType)
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
                int hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.SuccessfullyClosed.GetHashCode();
                hashCode = hashCode * 59 + this.IsFirstRun.GetHashCode();
                hashCode = hashCode * 59 + this.IsUpgrade.GetHashCode();
                if (this.PushNotificationPayload != null)
                    hashCode = hashCode * 59 + this.PushNotificationPayload.GetHashCode();
                if (this.LaunchReferral != null)
                    hashCode = hashCode * 59 + this.LaunchReferral.GetHashCode();
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

        /// <summary>
        /// Defines ApplicationTransitionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationTransitionTypeEnum
        {
            /// <summary>
            /// Enum Initialized for value: application_initialized
            /// </summary>
            [EnumMember(Value = "application_initialized")]
            Initialized = 1,

            /// <summary>
            /// Enum Exit for value: application_exit
            /// </summary>
            [EnumMember(Value = "application_exit")]
            Exit = 2,

            /// <summary>
            /// Enum Background for value: application_background
            /// </summary>
            [EnumMember(Value = "application_background")]
            Background = 3,

            /// <summary>
            /// Enum Foreground for value: application_foreground
            /// </summary>
            [EnumMember(Value = "application_foreground")]
            Foreground = 4

        }
    }

}
