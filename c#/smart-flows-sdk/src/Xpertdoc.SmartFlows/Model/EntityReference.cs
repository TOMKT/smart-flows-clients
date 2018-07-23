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
    /// EntityReference
    /// </summary>
    [DataContract]
    public partial class EntityReference :  IEquatable<EntityReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityReference" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="Lookups">Lookups.</param>
        /// <param name="Relationships">Relationships.</param>
        public EntityReference(string Name = default(string), string DisplayName = default(string), List<EntityReferenceFields> Fields = default(List<EntityReferenceFields>), List<EntityReferenceLookups> Lookups = default(List<EntityReferenceLookups>), List<EntityReferenceRelationships> Relationships = default(List<EntityReferenceRelationships>))
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.Fields = Fields;
            this.Lookups = Lookups;
            this.Relationships = Relationships;
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
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<EntityReferenceFields> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Lookups
        /// </summary>
        [DataMember(Name="lookups", EmitDefaultValue=false)]
        public List<EntityReferenceLookups> Lookups { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name="relationships", EmitDefaultValue=false)]
        public List<EntityReferenceRelationships> Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EntityReference {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Lookups: ").Append(Lookups).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(input as EntityReference);
        }

        /// <summary>
        /// Returns true if EntityReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Lookups == input.Lookups ||
                    this.Lookups != null &&
                    this.Lookups.SequenceEqual(input.Lookups)
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Lookups != null)
                    hashCode = hashCode * 59 + this.Lookups.GetHashCode();
                if (this.Relationships != null)
                    hashCode = hashCode * 59 + this.Relationships.GetHashCode();
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
