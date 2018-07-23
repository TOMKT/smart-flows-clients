/* 
 * Xpertdoc SmartFlows
 *
 * This describes the REST api for one Xpertdoc SmartFlows project
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
using SwaggerDateConverter = Xpertdoc.SmartFlows.Client.Client.SwaggerDateConverter;

namespace Xpertdoc.SmartFlows.Client.Model
{
    /// <summary>
    /// Data
    /// </summary>
    [DataContract]
    public partial class Data :  IEquatable<Data>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Reference for "reference"
            /// </summary>
            [EnumMember(Value = "reference")]
            Reference,
            
            /// <summary>
            /// Enum Value for "value"
            /// </summary>
            [EnumMember(Value = "value")]
            Value
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ModifiedAt">ModifiedAt.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="Dataset">Dataset.</param>
        /// <param name="PluginDataset">PluginDataset.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Reference">Reference.</param>
        /// <param name="DataAvailable">DataAvailable.</param>
        /// <param name="Expiration">Expiration.</param>
        /// <param name="Usage">Usage.</param>
        /// <param name="FlowExecution">FlowExecution.</param>
        /// <param name="ContentType">ContentType.</param>
        public Data(string Id = default(string), string DisplayName = default(string), string Description = default(string), string CreatedAt = default(string), IdWithName CreatedBy = default(IdWithName), string ModifiedAt = default(string), IdWithName ModifiedBy = default(IdWithName), IdWithName Dataset = default(IdWithName), IdWithName PluginDataset = default(IdWithName), TypeEnum? Type = default(TypeEnum?), DataValue Value = default(DataValue), DataReference Reference = default(DataReference), bool? DataAvailable = default(bool?), string Expiration = default(string), ObjectUsage Usage = default(ObjectUsage), FlowExecution FlowExecution = default(FlowExecution), string ContentType = default(string))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
            this.CreatedBy = CreatedBy;
            this.ModifiedAt = ModifiedAt;
            this.ModifiedBy = ModifiedBy;
            this.Dataset = Dataset;
            this.PluginDataset = PluginDataset;
            this.Type = Type;
            this.Value = Value;
            this.Reference = Reference;
            this.DataAvailable = DataAvailable;
            this.Expiration = Expiration;
            this.Usage = Usage;
            this.FlowExecution = FlowExecution;
            this.ContentType = ContentType;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public IdWithName CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public IdWithName ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name="dataset", EmitDefaultValue=false)]
        public IdWithName Dataset { get; set; }

        /// <summary>
        /// Gets or Sets PluginDataset
        /// </summary>
        [DataMember(Name="pluginDataset", EmitDefaultValue=false)]
        public IdWithName PluginDataset { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DataValue Value { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public DataReference Reference { get; set; }

        /// <summary>
        /// Gets or Sets DataAvailable
        /// </summary>
        [DataMember(Name="dataAvailable", EmitDefaultValue=false)]
        public bool? DataAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public ObjectUsage Usage { get; set; }

        /// <summary>
        /// Gets or Sets FlowExecution
        /// </summary>
        [DataMember(Name="flowExecution", EmitDefaultValue=false)]
        public FlowExecution FlowExecution { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
            sb.Append("  PluginDataset: ").Append(PluginDataset).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  DataAvailable: ").Append(DataAvailable).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  FlowExecution: ").Append(FlowExecution).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Data);
        }

        /// <summary>
        /// Returns true if Data instances are equal
        /// </summary>
        /// <param name="other">Instance of Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Data other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.ModifiedAt == other.ModifiedAt ||
                    this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(other.ModifiedAt)
                ) && 
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) && 
                (
                    this.Dataset == other.Dataset ||
                    this.Dataset != null &&
                    this.Dataset.Equals(other.Dataset)
                ) && 
                (
                    this.PluginDataset == other.PluginDataset ||
                    this.PluginDataset != null &&
                    this.PluginDataset.Equals(other.PluginDataset)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.DataAvailable == other.DataAvailable ||
                    this.DataAvailable != null &&
                    this.DataAvailable.Equals(other.DataAvailable)
                ) && 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) && 
                (
                    this.Usage == other.Usage ||
                    this.Usage != null &&
                    this.Usage.Equals(other.Usage)
                ) && 
                (
                    this.FlowExecution == other.FlowExecution ||
                    this.FlowExecution != null &&
                    this.FlowExecution.Equals(other.FlowExecution)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedAt != null)
                    hash = hash * 59 + this.ModifiedAt.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.Dataset != null)
                    hash = hash * 59 + this.Dataset.GetHashCode();
                if (this.PluginDataset != null)
                    hash = hash * 59 + this.PluginDataset.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.DataAvailable != null)
                    hash = hash * 59 + this.DataAvailable.GetHashCode();
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                if (this.Usage != null)
                    hash = hash * 59 + this.Usage.GetHashCode();
                if (this.FlowExecution != null)
                    hash = hash * 59 + this.FlowExecution.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DisplayName (string) maxLength
            if(this.DisplayName != null && this.DisplayName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be less than 255.", new [] { "DisplayName" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2048.", new [] { "Description" });
            }

            yield break;
        }
    }

}
