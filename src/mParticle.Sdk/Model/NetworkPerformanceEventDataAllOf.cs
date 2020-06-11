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
    /// NetworkPerformanceEventDataAllOf
    /// </summary>
    [DataContract]
    public partial class NetworkPerformanceEventDataAllOf :  IEquatable<NetworkPerformanceEventDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPerformanceEventDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetworkPerformanceEventDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPerformanceEventDataAllOf" /> class.
        /// </summary>
        /// <param name="httpVerb">httpVerb.</param>
        /// <param name="url">url (required).</param>
        /// <param name="timeElapsed">timeElapsed.</param>
        /// <param name="bytesIn">bytesIn.</param>
        /// <param name="bytesOut">bytesOut.</param>
        /// <param name="responseCode">responseCode (required).</param>
        /// <param name="data">data.</param>
        public NetworkPerformanceEventDataAllOf(string httpVerb = default(string), string url = default(string), int timeElapsed = default(int), int bytesIn = default(int), int bytesOut = default(int), int responseCode = default(int), string data = default(string))
        {
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for NetworkPerformanceEventDataAllOf and cannot be null");
            this.ResponseCode = responseCode;
            this.HttpVerb = httpVerb;
            this.TimeElapsed = timeElapsed;
            this.BytesIn = bytesIn;
            this.BytesOut = bytesOut;
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets HttpVerb
        /// </summary>
        [DataMember(Name="http_verb", EmitDefaultValue=false)]
        public string HttpVerb { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets TimeElapsed
        /// </summary>
        [DataMember(Name="time_elapsed", EmitDefaultValue=false)]
        public int TimeElapsed { get; set; }

        /// <summary>
        /// Gets or Sets BytesIn
        /// </summary>
        [DataMember(Name="bytes_in", EmitDefaultValue=false)]
        public int BytesIn { get; set; }

        /// <summary>
        /// Gets or Sets BytesOut
        /// </summary>
        [DataMember(Name="bytes_out", EmitDefaultValue=false)]
        public int BytesOut { get; set; }

        /// <summary>
        /// Gets or Sets ResponseCode
        /// </summary>
        [DataMember(Name="response_code", EmitDefaultValue=false)]
        public int ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkPerformanceEventDataAllOf {\n");
            sb.Append("  HttpVerb: ").Append(HttpVerb).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  TimeElapsed: ").Append(TimeElapsed).Append("\n");
            sb.Append("  BytesIn: ").Append(BytesIn).Append("\n");
            sb.Append("  BytesOut: ").Append(BytesOut).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as NetworkPerformanceEventDataAllOf);
        }

        /// <summary>
        /// Returns true if NetworkPerformanceEventDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkPerformanceEventDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkPerformanceEventDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpVerb == input.HttpVerb ||
                    (this.HttpVerb != null &&
                    this.HttpVerb.Equals(input.HttpVerb))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.TimeElapsed == input.TimeElapsed ||
                    this.TimeElapsed.Equals(input.TimeElapsed)
                ) && 
                (
                    this.BytesIn == input.BytesIn ||
                    this.BytesIn.Equals(input.BytesIn)
                ) && 
                (
                    this.BytesOut == input.BytesOut ||
                    this.BytesOut.Equals(input.BytesOut)
                ) && 
                (
                    this.ResponseCode == input.ResponseCode ||
                    this.ResponseCode.Equals(input.ResponseCode)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.HttpVerb != null)
                    hashCode = hashCode * 59 + this.HttpVerb.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.TimeElapsed.GetHashCode();
                hashCode = hashCode * 59 + this.BytesIn.GetHashCode();
                hashCode = hashCode * 59 + this.BytesOut.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
