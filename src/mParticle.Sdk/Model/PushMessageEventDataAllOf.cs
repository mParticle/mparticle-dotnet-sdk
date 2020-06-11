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
    /// PushMessageEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class PushMessageEventDataAllOf :  IEquatable<PushMessageEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Defines PushMessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PushMessageTypeEnum
        {
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 1,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 2,

            /// <summary>
            /// Enum Action for value: action
            /// </summary>
            [EnumMember(Value = "action")]
            Action = 3

        }

        /// <summary>
        /// Gets or Sets PushMessageType
        /// </summary>
        [DataMember(Name="push_message_type", EmitDefaultValue=false)]
        public PushMessageTypeEnum PushMessageType { get; set; }
        /// <summary>
        /// Defines ApplicationState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationStateEnum
        {
            /// <summary>
            /// Enum Notrunning for value: not_running
            /// </summary>
            [EnumMember(Value = "not_running")]
            Notrunning = 1,

            /// <summary>
            /// Enum Background for value: background
            /// </summary>
            [EnumMember(Value = "background")]
            Background = 2,

            /// <summary>
            /// Enum Foreground for value: foreground
            /// </summary>
            [EnumMember(Value = "foreground")]
            Foreground = 3

        }

        /// <summary>
        /// Gets or Sets ApplicationState
        /// </summary>
        [DataMember(Name="application_state", EmitDefaultValue=false)]
        public ApplicationStateEnum? ApplicationState { get; set; }
        /// <summary>
        /// Defines PushMessageBehavior
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PushMessageBehaviorEnum
        {
            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 1,

            /// <summary>
            /// Enum DirectOpen for value: DirectOpen
            /// </summary>
            [EnumMember(Value = "DirectOpen")]
            DirectOpen = 2,

            /// <summary>
            /// Enum Read for value: Read
            /// </summary>
            [EnumMember(Value = "Read")]
            Read = 3,

            /// <summary>
            /// Enum InfluencedOpen for value: InfluencedOpen
            /// </summary>
            [EnumMember(Value = "InfluencedOpen")]
            InfluencedOpen = 4,

            /// <summary>
            /// Enum Displayed for value: Displayed
            /// </summary>
            [EnumMember(Value = "Displayed")]
            Displayed = 5

        }

        /// <summary>
        /// Gets or Sets PushMessageBehavior
        /// </summary>
        [DataMember(Name="push_message_behavior", EmitDefaultValue=false)]
        public PushMessageBehaviorEnum? PushMessageBehavior { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMessageEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushMessageEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushMessageEventDataAllOf" /> class.
        /// </summary>
        /// <param name="pushMessageToken">pushMessageToken (required).</param>
        /// <param name="pushMessageType">pushMessageType (required).</param>
        /// <param name="message">message.</param>
        /// <param name="network">network.</param>
        /// <param name="pushNotificationPayload">pushNotificationPayload (required).</param>
        /// <param name="applicationState">applicationState.</param>
        /// <param name="actionIdentifier">actionIdentifier.</param>
        /// <param name="pushMessageBehavior">pushMessageBehavior.</param>
        public PushMessageEventDataAllOf(string pushMessageToken = default(string), PushMessageTypeEnum pushMessageType = default(PushMessageTypeEnum), string message = default(string), string network = default(string), string pushNotificationPayload = default(string), ApplicationStateEnum? applicationState = default(ApplicationStateEnum?), string actionIdentifier = default(string), PushMessageBehaviorEnum? pushMessageBehavior = default(PushMessageBehaviorEnum?))
        {
            // to ensure "pushMessageToken" is required (not null)
            this.PushMessageToken = pushMessageToken ?? throw new ArgumentNullException("pushMessageToken is a required property for PushMessageEventDataAllOf and cannot be null");
            this.PushMessageType = pushMessageType;
            // to ensure "pushNotificationPayload" is required (not null)
            this.PushNotificationPayload = pushNotificationPayload ?? throw new ArgumentNullException("pushNotificationPayload is a required property for PushMessageEventDataAllOf and cannot be null");
            this.Message = message;
            this.Network = network;
            this.ApplicationState = applicationState;
            this.ActionIdentifier = actionIdentifier;
            this.PushMessageBehavior = pushMessageBehavior;
        }
        
        /// <summary>
        /// Gets or Sets PushMessageToken
        /// </summary>
        [DataMember(Name="push_message_token", EmitDefaultValue=false)]
        public string PushMessageToken { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationPayload
        /// </summary>
        [DataMember(Name="push_notification_payload", EmitDefaultValue=false)]
        public string PushNotificationPayload { get; set; }

        /// <summary>
        /// Gets or Sets ActionIdentifier
        /// </summary>
        [DataMember(Name="action_identifier", EmitDefaultValue=false)]
        public string ActionIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushMessageEventDataAllOf {\n");
            sb.Append("  PushMessageToken: ").Append(PushMessageToken).Append("\n");
            sb.Append("  PushMessageType: ").Append(PushMessageType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  PushNotificationPayload: ").Append(PushNotificationPayload).Append("\n");
            sb.Append("  ApplicationState: ").Append(ApplicationState).Append("\n");
            sb.Append("  ActionIdentifier: ").Append(ActionIdentifier).Append("\n");
            sb.Append("  PushMessageBehavior: ").Append(PushMessageBehavior).Append("\n");
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
            return this.Equals(input as PushMessageEventDataAllOf);
        }

        /// <summary>
        /// Returns true if PushMessageEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PushMessageEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushMessageEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PushMessageToken == input.PushMessageToken ||
                    (this.PushMessageToken != null &&
                    this.PushMessageToken.Equals(input.PushMessageToken))
                ) && 
                (
                    this.PushMessageType == input.PushMessageType ||
                    this.PushMessageType.Equals(input.PushMessageType)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.PushNotificationPayload == input.PushNotificationPayload ||
                    (this.PushNotificationPayload != null &&
                    this.PushNotificationPayload.Equals(input.PushNotificationPayload))
                ) && 
                (
                    this.ApplicationState == input.ApplicationState ||
                    this.ApplicationState.Equals(input.ApplicationState)
                ) && 
                (
                    this.ActionIdentifier == input.ActionIdentifier ||
                    (this.ActionIdentifier != null &&
                    this.ActionIdentifier.Equals(input.ActionIdentifier))
                ) && 
                (
                    this.PushMessageBehavior == input.PushMessageBehavior ||
                    this.PushMessageBehavior.Equals(input.PushMessageBehavior)
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
                if (this.PushMessageToken != null)
                    hashCode = hashCode * 59 + this.PushMessageToken.GetHashCode();
                hashCode = hashCode * 59 + this.PushMessageType.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.PushNotificationPayload != null)
                    hashCode = hashCode * 59 + this.PushNotificationPayload.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationState.GetHashCode();
                if (this.ActionIdentifier != null)
                    hashCode = hashCode * 59 + this.ActionIdentifier.GetHashCode();
                hashCode = hashCode * 59 + this.PushMessageBehavior.GetHashCode();
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
