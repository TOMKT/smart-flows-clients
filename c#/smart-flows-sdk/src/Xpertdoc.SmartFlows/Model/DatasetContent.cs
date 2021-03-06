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
    /// DatasetContent
    /// </summary>
    [DataContract]
    public partial class DatasetContent :  IEquatable<DatasetContent>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Standard for value: standard
            /// </summary>
            [EnumMember(Value = "standard")]
            Standard = 1,
            
            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 2,
            
            /// <summary>
            /// Enum Schema for value: schema
            /// </summary>
            [EnumMember(Value = "schema")]
            Schema = 3,
            
            /// <summary>
            /// Enum Extended for value: extended
            /// </summary>
            [EnumMember(Value = "extended")]
            Extended = 4
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetContent" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="StandardContent">StandardContent.</param>
        /// <param name="CustomContent">CustomContent.</param>
        /// <param name="SchemaContent">SchemaContent.</param>
        /// <param name="ExtendedContent">ExtendedContent.</param>
        public DatasetContent(TypeEnum? Type = default(TypeEnum?), DatasetStandardContent StandardContent = default(DatasetStandardContent), DatasetCustomContent CustomContent = default(DatasetCustomContent), DatasetSchemaContent SchemaContent = default(DatasetSchemaContent), DatasetExtendedContent ExtendedContent = default(DatasetExtendedContent))
        {
            this.Type = Type;
            this.StandardContent = StandardContent;
            this.CustomContent = CustomContent;
            this.SchemaContent = SchemaContent;
            this.ExtendedContent = ExtendedContent;
        }
        

        /// <summary>
        /// Gets or Sets StandardContent
        /// </summary>
        [DataMember(Name="standardContent", EmitDefaultValue=false)]
        public DatasetStandardContent StandardContent { get; set; }

        /// <summary>
        /// Gets or Sets CustomContent
        /// </summary>
        [DataMember(Name="customContent", EmitDefaultValue=false)]
        public DatasetCustomContent CustomContent { get; set; }

        /// <summary>
        /// Gets or Sets SchemaContent
        /// </summary>
        [DataMember(Name="schemaContent", EmitDefaultValue=false)]
        public DatasetSchemaContent SchemaContent { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedContent
        /// </summary>
        [DataMember(Name="extendedContent", EmitDefaultValue=false)]
        public DatasetExtendedContent ExtendedContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetContent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StandardContent: ").Append(StandardContent).Append("\n");
            sb.Append("  CustomContent: ").Append(CustomContent).Append("\n");
            sb.Append("  SchemaContent: ").Append(SchemaContent).Append("\n");
            sb.Append("  ExtendedContent: ").Append(ExtendedContent).Append("\n");
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
            return this.Equals(input as DatasetContent);
        }

        /// <summary>
        /// Returns true if DatasetContent instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetContent input)
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
                    this.StandardContent == input.StandardContent ||
                    (this.StandardContent != null &&
                    this.StandardContent.Equals(input.StandardContent))
                ) && 
                (
                    this.CustomContent == input.CustomContent ||
                    (this.CustomContent != null &&
                    this.CustomContent.Equals(input.CustomContent))
                ) && 
                (
                    this.SchemaContent == input.SchemaContent ||
                    (this.SchemaContent != null &&
                    this.SchemaContent.Equals(input.SchemaContent))
                ) && 
                (
                    this.ExtendedContent == input.ExtendedContent ||
                    (this.ExtendedContent != null &&
                    this.ExtendedContent.Equals(input.ExtendedContent))
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
                if (this.StandardContent != null)
                    hashCode = hashCode * 59 + this.StandardContent.GetHashCode();
                if (this.CustomContent != null)
                    hashCode = hashCode * 59 + this.CustomContent.GetHashCode();
                if (this.SchemaContent != null)
                    hashCode = hashCode * 59 + this.SchemaContent.GetHashCode();
                if (this.ExtendedContent != null)
                    hashCode = hashCode * 59 + this.ExtendedContent.GetHashCode();
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
