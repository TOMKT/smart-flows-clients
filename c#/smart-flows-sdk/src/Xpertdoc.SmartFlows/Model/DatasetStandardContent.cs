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
    /// DatasetStandardContent
    /// </summary>
    [DataContract]
    public partial class DatasetStandardContent :  IEquatable<DatasetStandardContent>, IValidatableObject
    {
        /// <summary>
        /// Defines AllowedTypesOfData
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedTypesOfDataEnum
        {
            
            /// <summary>
            /// Enum Value for value: value
            /// </summary>
            [EnumMember(Value = "value")]
            Value = 1,
            
            /// <summary>
            /// Enum Reference for value: reference
            /// </summary>
            [EnumMember(Value = "reference")]
            Reference = 2
        }


        /// <summary>
        /// Gets or Sets AllowedTypesOfData
        /// </summary>
        [DataMember(Name="allowedTypesOfData", EmitDefaultValue=false)]
        public List<AllowedTypesOfDataEnum> AllowedTypesOfData { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStandardContent" /> class.
        /// </summary>
        /// <param name="WrapperElementName">WrapperElementName.</param>
        /// <param name="PrimaryEntity">PrimaryEntity.</param>
        /// <param name="AllowedTypesOfData">AllowedTypesOfData.</param>
        /// <param name="Entities">Entities.</param>
        /// <param name="Queries">Queries.</param>
        public DatasetStandardContent(string WrapperElementName = default(string), string PrimaryEntity = default(string), List<AllowedTypesOfDataEnum> AllowedTypesOfData = default(List<AllowedTypesOfDataEnum>), List<EntityReference> Entities = default(List<EntityReference>), DatasetStandardContentQueries Queries = default(DatasetStandardContentQueries))
        {
            this.WrapperElementName = WrapperElementName;
            this.PrimaryEntity = PrimaryEntity;
            this.AllowedTypesOfData = AllowedTypesOfData;
            this.Entities = Entities;
            this.Queries = Queries;
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
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EntityReference> Entities { get; set; }

        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public DatasetStandardContentQueries Queries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetStandardContent {\n");
            sb.Append("  WrapperElementName: ").Append(WrapperElementName).Append("\n");
            sb.Append("  PrimaryEntity: ").Append(PrimaryEntity).Append("\n");
            sb.Append("  AllowedTypesOfData: ").Append(AllowedTypesOfData).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
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
            return this.Equals(input as DatasetStandardContent);
        }

        /// <summary>
        /// Returns true if DatasetStandardContent instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetStandardContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetStandardContent input)
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
                    this.AllowedTypesOfData == input.AllowedTypesOfData ||
                    this.AllowedTypesOfData != null &&
                    this.AllowedTypesOfData.SequenceEqual(input.AllowedTypesOfData)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.Queries == input.Queries ||
                    (this.Queries != null &&
                    this.Queries.Equals(input.Queries))
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
                if (this.AllowedTypesOfData != null)
                    hashCode = hashCode * 59 + this.AllowedTypesOfData.GetHashCode();
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
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
