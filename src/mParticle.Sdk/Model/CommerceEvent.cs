using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using EventTypeEnum = mParticle.Model.EventType;
using Newtonsoft.Json.Converters;
using System.Collections.ObjectModel;
using System.Linq;

namespace mParticle.Model
{
    /// <summary>
    /// CommerceEvent
    /// </summary>
    [DataContract]
    public partial class CommerceEvent : BaseEvent, IEquatable<CommerceEvent>, IValidatableObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceEvent" /> class.
        /// </summary>
        public CommerceEvent(): base(EventTypeEnum.Commerceevent)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceEvent" /> class.
        /// </summary>
        /// <param name="productAction">the ProductAction for initialization</param>
        public CommerceEvent(ProductAction productAction): this()
        {
            ProductAction = productAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceEvent" /> class.
        /// </summary>
        /// <param name="promotionAction">the PromotionAction for initialization</param>
        public CommerceEvent(PromotionAction promotionAction): this()
        {
            PromotionAction = promotionAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceEvent" /> class.
        /// </summary>
        /// <param name="productImpressions">the ProductImpression Collection for initialization</param>
        public CommerceEvent(Collection<ProductImpression> productImpressions):this()
        {
            ProductImpressions = productImpressions;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommerceEvent {\n");
            sb.Append(base.ToString());
            sb.Append("  ProductAction: ").Append(ProductAction).Append("\n");
            sb.Append("  PromotionAction: ").Append(PromotionAction).Append("\n");
            sb.Append("  ProductImpressions: ").Append(ProductImpressions).Append("\n");
            sb.Append("  ShoppingCart: ").Append(ShoppingCart).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
            sb.Append("  IsNonInteractive: ").Append(IsNonInteractive).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  CustomFlags: ").Append(CustomFlags).Append("\n");
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
            return this.Equals(input as CommerceEvent);
        }

        /// <summary>
        /// Returns true if CommerceEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of CommerceEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceEvent input)
        {
            if (input == null)
                return false;

            return 
                base.Equals(input) &&
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
        /// Defines CustomEventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        
        public enum CommerceEventTypeEnum
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
    }

}
