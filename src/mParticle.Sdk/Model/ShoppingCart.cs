using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace mParticle.Model
{
    /// <summary>
    /// ShoppingCart
    /// </summary>
    [DataContract]
    public partial class ShoppingCart : IEquatable<ShoppingCart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShoppingCart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart" /> class.
        /// </summary>
        /// <param name="products">products (required).</param>
        public ShoppingCart(Collection<Product> products)
        {
            // to ensure "products" is required (not null)
            this.Products = products ?? throw new ArgumentNullException("products is a required property for ShoppingCart and cannot be null");
        }

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
            sb.Append("class ShoppingCart {\n");
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
            return this.Equals(input as ShoppingCart);
        }

        /// <summary>
        /// Returns true if ShoppingCart instances are equal
        /// </summary>
        /// <param name="input">Instance of ShoppingCart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShoppingCart input)
        {
            if (input == null)
                return false;

            return
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
