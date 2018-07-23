/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// CustomContentFieldNumber
    /// </summary>
    [DataContract]
    public partial class CustomContentFieldNumber :  IEquatable<CustomContentFieldNumber>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 1,
            
            /// <summary>
            /// Enum Real for value: real
            /// </summary>
            [EnumMember(Value = "real")]
            Real = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomContentFieldNumber" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="MinValue">MinValue.</param>
        /// <param name="MaxValue">MaxValue.</param>
        /// <param name="_Default">_Default.</param>
        public CustomContentFieldNumber(TypeEnum? Type = default(TypeEnum?), decimal? MinValue = default(decimal?), decimal? MaxValue = default(decimal?), decimal? _Default = default(decimal?))
        {
            this.Type = Type;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
            this._Default = _Default;
        }
        

        /// <summary>
        /// Gets or Sets MinValue
        /// </summary>
        [DataMember(Name="minValue", EmitDefaultValue=false)]
        public decimal? MinValue { get; set; }

        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [DataMember(Name="maxValue", EmitDefaultValue=false)]
        public decimal? MaxValue { get; set; }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public decimal? _Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomContentFieldNumber {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as CustomContentFieldNumber);
        }

        /// <summary>
        /// Returns true if CustomContentFieldNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomContentFieldNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomContentFieldNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    (this.MinValue != null &&
                    this.MinValue.Equals(input.MinValue))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    (this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue))
                ) && 
                (
                    this._Default == input._Default ||
                    (this._Default != null &&
                    this._Default.Equals(input._Default))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MinValue != null)
                    hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                if (this.MaxValue != null)
                    hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this._Default != null)
                    hashCode = hashCode * 59 + this._Default.GetHashCode();
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
