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
    /// DatasetCustomContent
    /// </summary>
    [DataContract]
    public partial class DatasetCustomContent :  IEquatable<DatasetCustomContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetCustomContent" /> class.
        /// </summary>
        /// <param name="WrapperElementName">WrapperElementName.</param>
        /// <param name="PrimaryEntity">PrimaryEntity.</param>
        /// <param name="Fields">Fields.</param>
        public DatasetCustomContent(string WrapperElementName = default(string), string PrimaryEntity = default(string), List<CustomContentField> Fields = default(List<CustomContentField>))
        {
            this.WrapperElementName = WrapperElementName;
            this.PrimaryEntity = PrimaryEntity;
            this.Fields = Fields;
        }
        
        /// <summary>
        /// Gets or Sets WrapperElementName
        /// </summary>
        [DataMember(Name="wrapperElementName", EmitDefaultValue=false)]
        public string WrapperElementName { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryEntity
        /// </summary>
        [DataMember(Name="primaryEntity", EmitDefaultValue=false)]
        public string PrimaryEntity { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<CustomContentField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetCustomContent {\n");
            sb.Append("  WrapperElementName: ").Append(WrapperElementName).Append("\n");
            sb.Append("  PrimaryEntity: ").Append(PrimaryEntity).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as DatasetCustomContent);
        }

        /// <summary>
        /// Returns true if DatasetCustomContent instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetCustomContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetCustomContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WrapperElementName == input.WrapperElementName ||
                    (this.WrapperElementName != null &&
                    this.WrapperElementName.Equals(input.WrapperElementName))
                ) && 
                (
                    this.PrimaryEntity == input.PrimaryEntity ||
                    (this.PrimaryEntity != null &&
                    this.PrimaryEntity.Equals(input.PrimaryEntity))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.WrapperElementName != null)
                    hashCode = hashCode * 59 + this.WrapperElementName.GetHashCode();
                if (this.PrimaryEntity != null)
                    hashCode = hashCode * 59 + this.PrimaryEntity.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
