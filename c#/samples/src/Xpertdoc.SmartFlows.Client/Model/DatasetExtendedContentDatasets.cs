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
    /// DatasetExtendedContentDatasets
    /// </summary>
    [DataContract]
    public partial class DatasetExtendedContentDatasets :  IEquatable<DatasetExtendedContentDatasets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExtendedContentDatasets" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DatasetId">DatasetId.</param>
        /// <param name="Field">Field.</param>
        public DatasetExtendedContentDatasets(string Name = default(string), string DatasetId = default(string), string Field = default(string))
        {
            this.Name = Name;
            this.DatasetId = DatasetId;
            this.Field = Field;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DatasetId
        /// </summary>
        [DataMember(Name="datasetId", EmitDefaultValue=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetExtendedContentDatasets {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(obj as DatasetExtendedContentDatasets);
        }

        /// <summary>
        /// Returns true if DatasetExtendedContentDatasets instances are equal
        /// </summary>
        /// <param name="other">Instance of DatasetExtendedContentDatasets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetExtendedContentDatasets other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DatasetId == other.DatasetId ||
                    this.DatasetId != null &&
                    this.DatasetId.Equals(other.DatasetId)
                ) && 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DatasetId != null)
                    hash = hash * 59 + this.DatasetId.GetHashCode();
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
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
            yield break;
        }
    }

}
