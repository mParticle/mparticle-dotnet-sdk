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
    /// ProductImpression
    /// </summary>
    [DataContract]
    public partial class ProductImpression :  IEquatable<ProductImpression>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductImpression" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductImpression() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductImpression" /> class.
        /// </summary>
        /// <param name="productImpressionList">productImpressionList (required).</param>
        /// <param name="products">products (required).</param>
        public ProductImpression(string productImpressionList = default(string), Collection<Product> products = default(Collection<Product>))
        {
            // to ensure "productImpressionList" is required (not null)
            this.ProductImpressionList = productImpressionList ?? throw new ArgumentNullException("productImpressionList is a required property for ProductImpression and cannot be null");
            // to ensure "products" is required (not null)
            this.Products = products ?? throw new ArgumentNullException("products is a required property for ProductImpression and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets ProductImpressionList
        /// </summary>
        [DataMember(Name="product_impression_list", EmitDefaultValue=false)]
        public string ProductImpressionList { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public Collection<Product> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductImpression {\n");
            sb.Append("  ProductImpressionList: ").Append(ProductImpressionList).Append("\n");
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
            return this.Equals(input as ProductImpression);
        }

        /// <summary>
        /// Returns true if ProductImpression instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductImpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductImpression input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductImpressionList == input.ProductImpressionList ||
                    (this.ProductImpressionList != null &&
                    this.ProductImpressionList.Equals(input.ProductImpressionList))
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
                if (this.ProductImpressionList != null)
                    hashCode = hashCode * 59 + this.ProductImpressionList.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
