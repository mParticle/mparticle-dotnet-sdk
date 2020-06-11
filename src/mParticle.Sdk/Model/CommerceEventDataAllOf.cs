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
    /// CommerceEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class CommerceEventDataAllOf :  IEquatable<CommerceEventDataAllOf>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="CommerceEventDataAllOf" /> class.
        /// </summary>
        /// <param name="productAction">productAction.</param>
        /// <param name="promotionAction">promotionAction.</param>
        /// <param name="productImpressions">productImpressions.</param>
        /// <param name="shoppingCart">shoppingCart.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="screenName">screenName.</param>
        /// <param name="isNonInteractive">isNonInteractive.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="customFlags">customFlags.</param>
        public CommerceEventDataAllOf(ProductAction productAction = default(ProductAction), PromotionAction promotionAction = default(PromotionAction), Collection<ProductImpression> productImpressions = default(Collection<ProductImpression>), ShoppingCart shoppingCart = default(ShoppingCart), string currencyCode = default(string), string screenName = default(string), bool isNonInteractive = default(bool), string eventName = default(string), Dictionary<string, string> customFlags = default(Dictionary<string, string>))
        {
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
            sb.Append("class CommerceEventDataAllOf {\n");
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
            return this.Equals(input as CommerceEventDataAllOf);
        }

        /// <summary>
        /// Returns true if CommerceEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CommerceEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
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
