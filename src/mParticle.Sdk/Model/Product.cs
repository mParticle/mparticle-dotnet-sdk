using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// Product
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="sku">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="brand">brand (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="variant">variant (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="couponCode">couponCode (required).</param>
        /// <param name="addedToCartTimeMs">addedToCartTimeMs (required).</param>
        /// <param name="totalProductAmount">totalProductAmount (required).</param>
        /// <param name="customAttributes">customAttributes (required).</param>
        public Product(string sku, string name, string brand = default(string), string category = default(string), string variant = default(string), int position = default(int), decimal price = default(decimal), decimal quantity = default(decimal), string couponCode = default(string), int addedToCartTimeMs = default(int), decimal totalProductAmount = default(decimal), Dictionary<string, string> customAttributes = default(Dictionary<string, string>))
        {
            // to ensure "id" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("id is a required property for Product and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for Product and cannot be null");
            this.Brand = brand;
            this.Category = category;
            this.Variant = variant;
            this.Position = position;
            this.Price = price;
            this.Quantity = quantity;
            this.CouponCode = couponCode;
            this.AddedToCartTimeMs = addedToCartTimeMs;
            this.TotalProductAmount = totalProductAmount;
            this.CustomAttributes = customAttributes;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Variant
        /// </summary>
        [DataMember(Name="variant", EmitDefaultValue=false)]
        public string Variant { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int Position { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        [DataMember(Name="coupon_code", EmitDefaultValue=false)]
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or Sets AddedToCartTimeMs
        /// </summary>
        [DataMember(Name="added_to_cart_time_ms", EmitDefaultValue=false)]
        public int AddedToCartTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets TotalProductAmount
        /// </summary>
        [DataMember(Name="total_product_amount", EmitDefaultValue=false)]
        public decimal TotalProductAmount { get; set; }

        /// <summary>
        /// Gets or Sets CustomAttributes
        /// </summary>
        [DataMember(Name="custom_attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  AddedToCartTimeMs: ").Append(AddedToCartTimeMs).Append("\n");
            sb.Append("  TotalProductAmount: ").Append(TotalProductAmount).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Variant == input.Variant ||
                    (this.Variant != null &&
                    this.Variant.Equals(input.Variant))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.CouponCode == input.CouponCode ||
                    (this.CouponCode != null &&
                    this.CouponCode.Equals(input.CouponCode))
                ) && 
                (
                    this.AddedToCartTimeMs == input.AddedToCartTimeMs ||
                    this.AddedToCartTimeMs.Equals(input.AddedToCartTimeMs)
                ) && 
                (
                    this.TotalProductAmount == input.TotalProductAmount ||
                    this.TotalProductAmount.Equals(input.TotalProductAmount)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes != null &&
                    input.CustomAttributes != null &&
                    this.CustomAttributes.SequenceEqual(input.CustomAttributes)
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
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Variant != null)
                    hashCode = hashCode * 59 + this.Variant.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.CouponCode != null)
                    hashCode = hashCode * 59 + this.CouponCode.GetHashCode();
                hashCode = hashCode * 59 + this.AddedToCartTimeMs.GetHashCode();
                hashCode = hashCode * 59 + this.TotalProductAmount.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
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
