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
    /// EntityDefinitionRelationships
    /// </summary>
    [DataContract]
    public partial class EntityDefinitionRelationships :  IEquatable<EntityDefinitionRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDefinitionRelationships" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="To">To.</param>
        /// <param name="ToField">ToField.</param>
        /// <param name="ManyToMany">ManyToMany (default to false).</param>
        public EntityDefinitionRelationships(string Name = default(string), string DisplayName = default(string), string Description = default(string), string To = default(string), string ToField = default(string), bool? ManyToMany = false)
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.To = To;
            this.ToField = ToField;
            // use default value if no "ManyToMany" provided
            if (ManyToMany == null)
            {
                this.ManyToMany = false;
            }
            else
            {
                this.ManyToMany = ManyToMany;
            }
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets ToField
        /// </summary>
        [DataMember(Name="toField", EmitDefaultValue=false)]
        public string ToField { get; set; }

        /// <summary>
        /// Gets or Sets ManyToMany
        /// </summary>
        [DataMember(Name="manyToMany", EmitDefaultValue=false)]
        public bool? ManyToMany { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityDefinitionRelationships {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToField: ").Append(ToField).Append("\n");
            sb.Append("  ManyToMany: ").Append(ManyToMany).Append("\n");
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
            return this.Equals(obj as EntityDefinitionRelationships);
        }

        /// <summary>
        /// Returns true if EntityDefinitionRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of EntityDefinitionRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityDefinitionRelationships other)
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
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.ToField == other.ToField ||
                    this.ToField != null &&
                    this.ToField.Equals(other.ToField)
                ) && 
                (
                    this.ManyToMany == other.ManyToMany ||
                    this.ManyToMany != null &&
                    this.ManyToMany.Equals(other.ManyToMany)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.ToField != null)
                    hash = hash * 59 + this.ToField.GetHashCode();
                if (this.ManyToMany != null)
                    hash = hash * 59 + this.ManyToMany.GetHashCode();
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
