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
    /// CommerceEventData
    /// </summary>
    [DataContract]
    public partial class CommerceEventData :  IEquatable<CommerceEventData>, IValidatableObject
    {
        /// <summary>
        /// Defines CustomEventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CustomEventTypeEnum
        {
            /// <summary>
            /// Enum Addtocart for value: add_to_cart
            /// </summary>
            [EnumMember(Value = "add_to_cart")]
            Addtocart = 1,

            /// <summary>
            /// Enum Removefromcart for value: remove_from_cart
            /// </summary>
            [EnumMember(Value = "remove_from_cart")]
            Removefromcart = 2,

            /// <summary>
            /// Enum Checkout for value: checkout
            /// </summary>
            [EnumMember(Value = "checkout")]
            Checkout = 3,

            /// <summary>
            /// Enum Checkoutoption for value: checkout_option
            /// </summary>
            [EnumMember(Value = "checkout_option")]
            Checkoutoption = 4,

            /// <summary>
            /// Enum Click for value: click
            /// </summary>
            [EnumMember(Value = "click")]
            Click = 5,

            /// <summary>
            /// Enum Viewdetail for value: view_detail
            /// </summary>
            [EnumMember(Value = "view_detail")]
            Viewdetail = 6,

            /// <summary>
            /// Enum Purchase for value: purchase
            /// </summary>
            [EnumMember(Value = "purchase")]
            Purchase = 7,

            /// <summary>
            /// Enum Refund for value: refund
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund = 8,

            /// <summary>
            /// Enum Promotionview for value: promotion_view
            /// </summary>
            [EnumMember(Value = "promotion_view")]
            Promotionview = 9,

            /// <summary>
            /// Enum Promotionclick for value: promotion_click
            /// </summary>
            [EnumMember(Value = "promotion_click")]
            Promotionclick = 10,

            /// <summary>
            /// Enum Addtowishlist for value: add_to_wishlist
            /// </summary>
            [EnumMember(Value = "add_to_wishlist")]
            Addtowishlist = 11,

            /// <summary>
            /// Enum Removefromwishlist for value: remove_from_wishlist
            /// </summary>
            [EnumMember(Value = "remove_from_wishlist")]
            Removefromwishlist = 12,

            /// <summary>
            /// Enum Impression for value: impression
            /// </summary>
            [EnumMember(Value = "impression")]
            Impression = 13

        }

        /// <summary>
        /// Gets or Sets CustomEventType
        /// </summary>
        [DataMember(Name="custom_event_type", EmitDefaultValue=false)]
        public CustomEventTypeEnum? CustomEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceEventData" /> class.
        /// </summary>
        /// <param name="timestampUnixtimeMs">timestampUnixtimeMs.</param>
        /// <param name="sourceMessageId">sourceMessageId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="sessionUuid">sessionUuid.</param>
        /// <param name="sessionStartUnixtimeMs">sessionStartUnixtimeMs.</param>
        /// <param name="eventStartUnixtimeMs">eventStartUnixtimeMs.</param>
        /// <param name="customAttributes">customAttributes.</param>
        /// <param name="location">location.</param>
        /// <param name="deviceCurrentState">deviceCurrentState.</param>
        /// <param name="isGoalDefined">isGoalDefined.</param>
        /// <param name="lifetimeValueChange">lifetimeValueChange.</param>
        /// <param name="lifetimeValueAttributeName">lifetimeValueAttributeName.</param>
        /// <param name="dataConnectionType">dataConnectionType.</param>
        /// <param name="eventNum">eventNum.</param>
        /// <param name="viewController">viewController.</param>
        /// <param name="isMainThread">isMainThread.</param>
        /// <param name="canonicalName">canonicalName.</param>
        /// <param name="eventSystemNotificationInfo">eventSystemNotificationInfo.</param>
        /// <param name="productAction">productAction.</param>
        /// <param name="promotionAction">promotionAction.</param>
        /// <param name="productImpressions">productImpressions.</param>
        /// <param name="shoppingCart">shoppingCart.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="screenName">screenName.</param>
        /// <param name="isNonInteractive">isNonInteractive.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="customFlags">customFlags.</param>
        public CommerceEventData(int timestampUnixtimeMs = default(int), string sourceMessageId = default(string), long sessionId = default(long), string sessionUuid = default(string), int sessionStartUnixtimeMs = default(int), int eventStartUnixtimeMs = default(int), Dictionary<string, string> customAttributes = default(Dictionary<string, string>), GeoLocation location = default(GeoLocation), DeviceCurrentState deviceCurrentState = default(DeviceCurrentState), bool isGoalDefined = default(bool), bool lifetimeValueChange = default(bool), string lifetimeValueAttributeName = default(string), string dataConnectionType = default(string), int eventNum = default(int), string viewController = default(string), bool isMainThread = default(bool), string canonicalName = default(string), EventSystemNotificationInfo eventSystemNotificationInfo = default(EventSystemNotificationInfo), ProductAction productAction = default(ProductAction), PromotionAction promotionAction = default(PromotionAction), Collection<ProductImpression> productImpressions = default(Collection<ProductImpression>), ShoppingCart shoppingCart = default(ShoppingCart), string currencyCode = default(string), string screenName = default(string), bool isNonInteractive = default(bool), string eventName = default(string), Dictionary<string, string> customFlags = default(Dictionary<string, string>))
        {
            this.TimestampUnixtimeMs = timestampUnixtimeMs;
            this.SourceMessageId = sourceMessageId;
            this.SessionId = sessionId;
            this.SessionUuid = sessionUuid;
            this.SessionStartUnixtimeMs = sessionStartUnixtimeMs;
            this.EventStartUnixtimeMs = eventStartUnixtimeMs;
            this.CustomAttributes = customAttributes;
            this.Location = location;
            this.DeviceCurrentState = deviceCurrentState;
            this.IsGoalDefined = isGoalDefined;
            this.LifetimeValueChange = lifetimeValueChange;
            this.LifetimeValueAttributeName = lifetimeValueAttributeName;
            this.DataConnectionType = dataConnectionType;
            this.EventNum = eventNum;
            this.ViewController = viewController;
            this.IsMainThread = isMainThread;
            this.CanonicalName = canonicalName;
            this.EventSystemNotificationInfo = eventSystemNotificationInfo;
            this.ProductAction = productAction;
            this.PromotionAction = promotionAction;
            this.ProductImpressions = productImpressions;
            this.ShoppingCart = shoppingCart;
            this.CurrencyCode = currencyCode;
            this.ScreenName = screenName;
            this.IsNonInteractive = isNonInteractive;
            this.EventName = eventName;
            this.CustomFlags = customFlags;
        }
        
        /// <summary>
        /// Gets or Sets TimestampUnixtimeMs
        /// </summary>
        [DataMember(Name="timestamp_unixtime_ms", EmitDefaultValue=false)]
        public int TimestampUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="event_id", EmitDefaultValue=false)]
        public long EventId { get; private set; }

        /// <summary>
        /// Gets or Sets SourceMessageId
        /// </summary>
        [DataMember(Name="source_message_id", EmitDefaultValue=false)]
        public string SourceMessageId { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="session_id", EmitDefaultValue=false)]
        public long SessionId { get; set; }

        /// <summary>
        /// Gets or Sets SessionUuid
        /// </summary>
        [DataMember(Name="session_uuid", EmitDefaultValue=false)]
        public string SessionUuid { get; set; }

        /// <summary>
        /// Gets or Sets SessionStartUnixtimeMs
        /// </summary>
        [DataMember(Name="session_start_unixtime_ms", EmitDefaultValue=false)]
        public int SessionStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EventStartUnixtimeMs
        /// </summary>
        [DataMember(Name="event_start_unixtime_ms", EmitDefaultValue=false)]
        public int EventStartUnixtimeMs { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public GeoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets DeviceCurrentState
        /// </summary>
        [DataMember(Name="device_current_state", EmitDefaultValue=false)]
        public DeviceCurrentState DeviceCurrentState { get; set; }

        /// <summary>
        /// Gets or Sets IsGoalDefined
        /// </summary>
        [DataMember(Name="is_goal_defined", EmitDefaultValue=false)]
        public bool IsGoalDefined { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueChange
        /// </summary>
        [DataMember(Name="lifetime_value_change", EmitDefaultValue=false)]
        public bool LifetimeValueChange { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeValueAttributeName
        /// </summary>
        [DataMember(Name="lifetime_value_attribute_name", EmitDefaultValue=false)]
        public string LifetimeValueAttributeName { get; set; }

        /// <summary>
        /// Gets or Sets DataConnectionType
        /// </summary>
        [DataMember(Name="data_connection_type", EmitDefaultValue=false)]
        public string DataConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets EventNum
        /// </summary>
        [DataMember(Name="event_num", EmitDefaultValue=false)]
        public int EventNum { get; set; }

        /// <summary>
        /// Gets or Sets ViewController
        /// </summary>
        [DataMember(Name="view_controller", EmitDefaultValue=false)]
        public string ViewController { get; set; }

        /// <summary>
        /// Gets or Sets IsMainThread
        /// </summary>
        [DataMember(Name="is_main_thread", EmitDefaultValue=false)]
        public bool IsMainThread { get; set; }

        /// <summary>
        /// Gets or Sets CanonicalName
        /// </summary>
        [DataMember(Name="canonical_name", EmitDefaultValue=false)]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Gets or Sets EventSystemNotificationInfo
        /// </summary>
        [DataMember(Name="event_system_notification_info", EmitDefaultValue=false)]
        public EventSystemNotificationInfo EventSystemNotificationInfo { get; set; }

        /// <summary>
        /// Gets or Sets ProductAction
        /// </summary>
        [DataMember(Name="product_action", EmitDefaultValue=false)]
        public ProductAction ProductAction { get; set; }

        /// <summary>
        /// Gets or Sets PromotionAction
        /// </summary>
        [DataMember(Name="promotion_action", EmitDefaultValue=false)]
        public PromotionAction PromotionAction { get; set; }

        /// <summary>
        /// Gets or Sets ProductImpressions
        /// </summary>
        [DataMember(Name="product_impressions", EmitDefaultValue=false)]
        public Collection<ProductImpression> ProductImpressions { get; set; }

        /// <summary>
        /// Gets or Sets ShoppingCart
        /// </summary>
        [DataMember(Name="shopping_cart", EmitDefaultValue=false)]
        public ShoppingCart ShoppingCart { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currency_code", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets ScreenName
        /// </summary>
        [DataMember(Name="screen_name", EmitDefaultValue=false)]
        public string ScreenName { get; set; }

        /// <summary>
        /// Gets or Sets IsNonInteractive
        /// </summary>
        [DataMember(Name="is_non_interactive", EmitDefaultValue=false)]
        public bool IsNonInteractive { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }

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
            sb.Append("class CommerceEventData {\n");
            sb.Append("  TimestampUnixtimeMs: ").Append(TimestampUnixtimeMs).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  SourceMessageId: ").Append(SourceMessageId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionUuid: ").Append(SessionUuid).Append("\n");
            sb.Append("  SessionStartUnixtimeMs: ").Append(SessionStartUnixtimeMs).Append("\n");
            sb.Append("  EventStartUnixtimeMs: ").Append(EventStartUnixtimeMs).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  DeviceCurrentState: ").Append(DeviceCurrentState).Append("\n");
            sb.Append("  IsGoalDefined: ").Append(IsGoalDefined).Append("\n");
            sb.Append("  LifetimeValueChange: ").Append(LifetimeValueChange).Append("\n");
            sb.Append("  LifetimeValueAttributeName: ").Append(LifetimeValueAttributeName).Append("\n");
            sb.Append("  DataConnectionType: ").Append(DataConnectionType).Append("\n");
            sb.Append("  EventNum: ").Append(EventNum).Append("\n");
            sb.Append("  ViewController: ").Append(ViewController).Append("\n");
            sb.Append("  IsMainThread: ").Append(IsMainThread).Append("\n");
            sb.Append("  CanonicalName: ").Append(CanonicalName).Append("\n");
            sb.Append("  EventSystemNotificationInfo: ").Append(EventSystemNotificationInfo).Append("\n");
            sb.Append("  ProductAction: ").Append(ProductAction).Append("\n");
            sb.Append("  PromotionAction: ").Append(PromotionAction).Append("\n");
            sb.Append("  ProductImpressions: ").Append(ProductImpressions).Append("\n");
            sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  IsNonInteractive: ").Append(IsNonInteractive).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CustomEventType: ").Append(CustomEventType).Append("\n");
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
            return this.Equals(input as CommerceEventData);
        }

        /// <summary>
        /// Returns true if CommerceEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of CommerceEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceEventData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestampUnixtimeMs == input.TimestampUnixtimeMs ||
                    this.TimestampUnixtimeMs.Equals(input.TimestampUnixtimeMs)
                ) && 
                (
                    this.EventId == input.EventId ||
                    this.EventId.Equals(input.EventId)
                ) && 
                (
                    this.SourceMessageId == input.SourceMessageId ||
                    (this.SourceMessageId != null &&
                    this.SourceMessageId.Equals(input.SourceMessageId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    this.SessionId.Equals(input.SessionId)
                ) && 
                (
                    this.SessionUuid == input.SessionUuid ||
                    (this.SessionUuid != null &&
                    this.SessionUuid.Equals(input.SessionUuid))
                ) && 
                (
                    this.SessionStartUnixtimeMs == input.SessionStartUnixtimeMs ||
                    this.SessionStartUnixtimeMs.Equals(input.SessionStartUnixtimeMs)
                ) && 
                (
                    this.EventStartUnixtimeMs == input.EventStartUnixtimeMs ||
                    this.EventStartUnixtimeMs.Equals(input.EventStartUnixtimeMs)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.DeviceCurrentState == input.DeviceCurrentState ||
                    (this.DeviceCurrentState != null &&
                    this.DeviceCurrentState.Equals(input.DeviceCurrentState))
                ) && 
                (
                    this.IsGoalDefined == input.IsGoalDefined ||
                    this.IsGoalDefined.Equals(input.IsGoalDefined)
                ) && 
                (
                    this.LifetimeValueChange == input.LifetimeValueChange ||
                    this.LifetimeValueChange.Equals(input.LifetimeValueChange)
                ) && 
                (
                    this.LifetimeValueAttributeName == input.LifetimeValueAttributeName ||
                    (this.LifetimeValueAttributeName != null &&
                    this.LifetimeValueAttributeName.Equals(input.LifetimeValueAttributeName))
                ) && 
                (
                    this.DataConnectionType == input.DataConnectionType ||
                    (this.DataConnectionType != null &&
                    this.DataConnectionType.Equals(input.DataConnectionType))
                ) && 
                (
                    this.EventNum == input.EventNum ||
                    this.EventNum.Equals(input.EventNum)
                ) && 
                (
                    this.ViewController == input.ViewController ||
                    (this.ViewController != null &&
                    this.ViewController.Equals(input.ViewController))
                ) && 
                (
                    this.IsMainThread == input.IsMainThread ||
                    this.IsMainThread.Equals(input.IsMainThread)
                ) && 
                (
                    this.CanonicalName == input.CanonicalName ||
                    (this.CanonicalName != null &&
                    this.CanonicalName.Equals(input.CanonicalName))
                ) && 
                (
                    this.EventSystemNotificationInfo == input.EventSystemNotificationInfo ||
                    (this.EventSystemNotificationInfo != null &&
                    this.EventSystemNotificationInfo.Equals(input.EventSystemNotificationInfo))
                ) && 
                (
                    this.ProductAction == input.ProductAction ||
                    (this.ProductAction != null &&
                    this.ProductAction.Equals(input.ProductAction))
                ) && 
                (
                    this.PromotionAction == input.PromotionAction ||
                    (this.PromotionAction != null &&
                    this.PromotionAction.Equals(input.PromotionAction))
                ) && 
                (
                    this.ProductImpressions == input.ProductImpressions ||
                    this.ProductImpressions != null &&
                    input.ProductImpressions != null &&
                    this.ProductImpressions.SequenceEqual(input.ProductImpressions)
                ) && 
                (
                    this.ShoppingCart == input.ShoppingCart ||
                    (this.ShoppingCart != null &&
                    this.ShoppingCart.Equals(input.ShoppingCart))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.ScreenName == input.ScreenName ||
                    (this.ScreenName != null &&
                    this.ScreenName.Equals(input.ScreenName))
                ) && 
                (
                    this.IsNonInteractive == input.IsNonInteractive ||
                    this.IsNonInteractive.Equals(input.IsNonInteractive)
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.CustomEventType == input.CustomEventType ||
                    this.CustomEventType.Equals(input.CustomEventType)
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
                hashCode = hashCode * 59 + this.TimestampUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.SourceMessageId != null)
                    hashCode = hashCode * 59 + this.SourceMessageId.GetHashCode();
                hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.SessionUuid != null)
                    hashCode = hashCode * 59 + this.SessionUuid.GetHashCode();
                hashCode = hashCode * 59 + this.SessionStartUnixtimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.EventStartUnixtimeMs.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.DeviceCurrentState != null)
                    hashCode = hashCode * 59 + this.DeviceCurrentState.GetHashCode();
                hashCode = hashCode * 59 + this.IsGoalDefined.GetHashCode();
                hashCode = hashCode * 59 + this.LifetimeValueChange.GetHashCode();
                if (this.LifetimeValueAttributeName != null)
                    hashCode = hashCode * 59 + this.LifetimeValueAttributeName.GetHashCode();
                if (this.DataConnectionType != null)
                    hashCode = hashCode * 59 + this.DataConnectionType.GetHashCode();
                hashCode = hashCode * 59 + this.EventNum.GetHashCode();
                if (this.ViewController != null)
                    hashCode = hashCode * 59 + this.ViewController.GetHashCode();
                hashCode = hashCode * 59 + this.IsMainThread.GetHashCode();
                if (this.CanonicalName != null)
                    hashCode = hashCode * 59 + this.CanonicalName.GetHashCode();
                if (this.EventSystemNotificationInfo != null)
                    hashCode = hashCode * 59 + this.EventSystemNotificationInfo.GetHashCode();
                if (this.ProductAction != null)
                    hashCode = hashCode * 59 + this.ProductAction.GetHashCode();
                if (this.PromotionAction != null)
                    hashCode = hashCode * 59 + this.PromotionAction.GetHashCode();
                if (this.ProductImpressions != null)
                    hashCode = hashCode * 59 + this.ProductImpressions.GetHashCode();
                if (this.ShoppingCart != null)
                    hashCode = hashCode * 59 + this.ShoppingCart.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.ScreenName != null)
                    hashCode = hashCode * 59 + this.ScreenName.GetHashCode();
                hashCode = hashCode * 59 + this.IsNonInteractive.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                hashCode = hashCode * 59 + this.CustomEventType.GetHashCode();
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
