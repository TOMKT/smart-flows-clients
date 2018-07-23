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
    /// ImportInformation
    /// </summary>
    [DataContract]
    public partial class ImportInformation :  IEquatable<ImportInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportInformation" /> class.
        /// </summary>
        /// <param name="Archive">Archive.</param>
        /// <param name="TopLevelItems">TopLevelItems.</param>
        /// <param name="SuggestedMappings">SuggestedMappings.</param>
        public ImportInformation(Archive Archive = default(Archive), List<IdWithName> TopLevelItems = default(List<IdWithName>), List<MultiDependencyMapping> SuggestedMappings = default(List<MultiDependencyMapping>))
        {
            this.Archive = Archive;
            this.TopLevelItems = TopLevelItems;
            this.SuggestedMappings = SuggestedMappings;
        }
        
        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name="archive", EmitDefaultValue=false)]
        public Archive Archive { get; set; }

        /// <summary>
        /// Gets or Sets TopLevelItems
        /// </summary>
        [DataMember(Name="topLevelItems", EmitDefaultValue=false)]
        public List<IdWithName> TopLevelItems { get; set; }

        /// <summary>
        /// Gets or Sets SuggestedMappings
        /// </summary>
        [DataMember(Name="suggestedMappings", EmitDefaultValue=false)]
        public List<MultiDependencyMapping> SuggestedMappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportInformation {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  TopLevelItems: ").Append(TopLevelItems).Append("\n");
            sb.Append("  SuggestedMappings: ").Append(SuggestedMappings).Append("\n");
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
            return this.Equals(input as ImportInformation);
        }

        /// <summary>
        /// Returns true if ImportInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) && 
                (
                    this.TopLevelItems == input.TopLevelItems ||
                    this.TopLevelItems != null &&
                    this.TopLevelItems.SequenceEqual(input.TopLevelItems)
                ) && 
                (
                    this.SuggestedMappings == input.SuggestedMappings ||
                    this.SuggestedMappings != null &&
                    this.SuggestedMappings.SequenceEqual(input.SuggestedMappings)
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
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.TopLevelItems != null)
                    hashCode = hashCode * 59 + this.TopLevelItems.GetHashCode();
                if (this.SuggestedMappings != null)
                    hashCode = hashCode * 59 + this.SuggestedMappings.GetHashCode();
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
