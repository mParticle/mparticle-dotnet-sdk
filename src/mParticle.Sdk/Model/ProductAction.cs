using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace mParticle.Model
{
    /// <summary>
    /// ProductAction
    /// </summary>
    [DataContract]
    public partial class ProductAction : IEquatable<ProductAction>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
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
            /// Enum Addtowishlist for value: add_to_wishlist
            /// </summary>
            [EnumMember(Value = "add_to_wishlist")]
            Addtowishlist = 9,

            /// <summary>
            /// Enum Removefromwishlist for value: remove_from_wish_list
            /// </summary>
            [EnumMember(Value = "remove_from_wish_list")]
            Removefromwishlist = 10

        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name= "action", EmitDefaultValue= false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAction" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="checkoutStep">checkoutStep (required).</param>
        /// <param name="checkoutOptions">checkoutOptions (required).</param>
        /// <param name="productActionList">productActionList (required).</param>
        /// <param name="productListSource">productListSource (required).</param>
        /// <param name="transactionId">transactionId (required).</param>
        /// <param name="affiliation">affiliation (required).</param>
        /// <param name="totalAmount">totalAmount (required).</param>
        /// <param name="taxAmount">taxAmount (required).</param>
        /// <param name="shippingAmount">shippingAmount (required).</param>
        /// <param name="couponCode">couponCode (required).</param>
        /// <param name="products">products (required).</param>
        public ProductAction(ActionEnum action, int checkoutStep = default(int), string checkoutOptions = default(string), string productActionList = default(string), string productListSource = default(string), string transactionId = default(string), string affiliation = default(string), decimal totalAmount = default(decimal), decimal taxAmount = default(decimal), decimal shippingAmount = default(decimal), string couponCode = default(string), Collection<Product> products = default(Collection<Product>))
        {
            this.Action = action;
            this.CheckoutStep = checkoutStep;
            // to ensure "checkoutOptions" is required (not null)
            this.CheckoutOptions = checkoutOptions;
            // to ensure "productActionList" is required (not null)
            this.ProductActionList = productActionList;
            // to ensure "productListSource" is required (not null)
            this.ProductListSource = productListSource;
            // to ensure "transactionId" is required (not null)
            this.TransactionId = transactionId;
            // to ensure "affiliation" is required (not null)
            this.Affiliation = affiliation;
            this.TotalAmount = totalAmount;
            this.TaxAmount = taxAmount;
            this.ShippingAmount = shippingAmount;
            // to ensure "couponCode" is required (not null)
            this.CouponCode = couponCode;
            // to ensure "products" is required (not null)
            this.Products = products;
        }

        /// <summary>
        /// Gets or Sets CheckoutStep
        /// </summary>
        [DataMember(Name= "checkout_step", EmitDefaultValue= false)]
        public int CheckoutStep { get; set; }

        /// <summary>
        /// Gets or Sets CheckoutOptions
        /// </summary>
        [DataMember(Name= "checkout_options", EmitDefaultValue= false)]
        public string CheckoutOptions { get; set; }

        /// <summary>
        /// Gets or Sets ProductActionList
        /// </summary>
        [DataMember(Name= "product_action_list", EmitDefaultValue= false)]
        public string ProductActionList { get; set; }

        /// <summary>
        /// Gets or Sets ProductListSource
        /// </summary>
        [DataMember(Name= "product_list_source", EmitDefaultValue= false)]
        public string ProductListSource { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name= "transaction_id", EmitDefaultValue= false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Affiliation
        /// </summary>
        [DataMember(Name= "affiliation", EmitDefaultValue= false)]
        public string Affiliation { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name= "total_amount", EmitDefaultValue= false)]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name= "tax_amount", EmitDefaultValue= false)]
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAmount
        /// </summary>
        [DataMember(Name= "shipping_amount", EmitDefaultValue= false)]
        public decimal ShippingAmount { get; set; }

        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        [DataMember(Name= "coupon_code", EmitDefaultValue= false)]
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name= "products", EmitDefaultValue= false)]
        public Collection<Product> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductAction {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CheckoutStep: ").Append(CheckoutStep).Append("\n");
            sb.Append("  CheckoutOptions: ").Append(CheckoutOptions).Append("\n");
            sb.Append("  ProductActionList: ").Append(ProductActionList).Append("\n");
            sb.Append("  ProductListSource: ").Append(ProductListSource).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Affiliation: ").Append(Affiliation).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  ShippingAmount: ").Append(ShippingAmount).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return this.Equals(input as ProductAction);
        }

        /// <summary>
        /// Returns true if ProductAction instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductAction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) &&
                (
                    this.CheckoutStep == input.CheckoutStep ||
                    this.CheckoutStep.Equals(input.CheckoutStep)
                ) &&
                (
                    this.CheckoutOptions == input.CheckoutOptions ||
                    (this.CheckoutOptions != null &&
                    this.CheckoutOptions.Equals(input.CheckoutOptions))
                ) &&
                (
                    this.ProductActionList == input.ProductActionList ||
                    (this.ProductActionList != null &&
                    this.ProductActionList.Equals(input.ProductActionList))
                ) &&
                (
                    this.ProductListSource == input.ProductListSource ||
                    (this.ProductListSource != null &&
                    this.ProductListSource.Equals(input.ProductListSource))
                ) &&
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) &&
                (
                    this.Affiliation == input.Affiliation ||
                    (this.Affiliation != null &&
                    this.Affiliation.Equals(input.Affiliation))
                ) &&
                (
                    this.TotalAmount == input.TotalAmount ||
                    this.TotalAmount.Equals(input.TotalAmount)
                ) &&
                (
                    this.TaxAmount == input.TaxAmount ||
                    this.TaxAmount.Equals(input.TaxAmount)
                ) &&
                (
                    this.ShippingAmount == input.ShippingAmount ||
                    this.ShippingAmount.Equals(input.ShippingAmount)
                ) &&
                (
                    this.CouponCode == input.CouponCode ||
                    (this.CouponCode != null &&
                    this.CouponCode.Equals(input.CouponCode))
                ) &&
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.CheckoutStep.GetHashCode();
                if (this.CheckoutOptions != null)
                    hashCode = hashCode * 59 + this.CheckoutOptions.GetHashCode();
                if (this.ProductActionList != null)
                    hashCode = hashCode * 59 + this.ProductActionList.GetHashCode();
                if (this.ProductListSource != null)
                    hashCode = hashCode * 59 + this.ProductListSource.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.Affiliation != null)
                    hashCode = hashCode * 59 + this.Affiliation.GetHashCode();
                hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                hashCode = hashCode * 59 + this.ShippingAmount.GetHashCode();
                if (this.CouponCode != null)
                    hashCode = hashCode * 59 + this.CouponCode.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
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
    }

}
