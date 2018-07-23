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
    /// FlatArchive
    /// </summary>
    [DataContract]
    public partial class FlatArchive :  IEquatable<FlatArchive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlatArchive" /> class.
        /// </summary>
        /// <param name="Archive">Archive.</param>
        /// <param name="Items">Items.</param>
        public FlatArchive(Archive Archive = default(Archive), List<ArchivableItem> Items = default(List<ArchivableItem>))
        {
            this.Archive = Archive;
            this.Items = Items;
        }
        
        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name="archive", EmitDefaultValue=false)]
        public Archive Archive { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ArchivableItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlatArchive {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as FlatArchive);
        }

        /// <summary>
        /// Returns true if FlatArchive instances are equal
        /// </summary>
        /// <param name="other">Instance of FlatArchive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlatArchive other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Archive == other.Archive ||
                    this.Archive != null &&
                    this.Archive.Equals(other.Archive)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.Archive != null)
                    hash = hash * 59 + this.Archive.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
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
