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
    /// SyncResult
    /// </summary>
    [DataContract]
    public partial class SyncResult :  IEquatable<SyncResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncResult" /> class.
        /// </summary>
        /// <param name="AddCount">AddCount.</param>
        /// <param name="UpdateCount">UpdateCount.</param>
        /// <param name="DeactivatedCount">DeactivatedCount.</param>
        public SyncResult(int? AddCount = default(int?), int? UpdateCount = default(int?), int? DeactivatedCount = default(int?))
        {
            this.AddCount = AddCount;
            this.UpdateCount = UpdateCount;
            this.DeactivatedCount = DeactivatedCount;
        }
        
        /// <summary>
        /// Gets or Sets AddCount
        /// </summary>
        [DataMember(Name="addCount", EmitDefaultValue=false)]
        public int? AddCount { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCount
        /// </summary>
        [DataMember(Name="updateCount", EmitDefaultValue=false)]
        public int? UpdateCount { get; set; }

        /// <summary>
        /// Gets or Sets DeactivatedCount
        /// </summary>
        [DataMember(Name="deactivatedCount", EmitDefaultValue=false)]
        public int? DeactivatedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncResult {\n");
            sb.Append("  AddCount: ").Append(AddCount).Append("\n");
            sb.Append("  UpdateCount: ").Append(UpdateCount).Append("\n");
            sb.Append("  DeactivatedCount: ").Append(DeactivatedCount).Append("\n");
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
            return this.Equals(obj as SyncResult);
        }

        /// <summary>
        /// Returns true if SyncResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SyncResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddCount == other.AddCount ||
                    this.AddCount != null &&
                    this.AddCount.Equals(other.AddCount)
                ) && 
                (
                    this.UpdateCount == other.UpdateCount ||
                    this.UpdateCount != null &&
                    this.UpdateCount.Equals(other.UpdateCount)
                ) && 
                (
                    this.DeactivatedCount == other.DeactivatedCount ||
                    this.DeactivatedCount != null &&
                    this.DeactivatedCount.Equals(other.DeactivatedCount)
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
                if (this.AddCount != null)
                    hash = hash * 59 + this.AddCount.GetHashCode();
                if (this.UpdateCount != null)
                    hash = hash * 59 + this.UpdateCount.GetHashCode();
                if (this.DeactivatedCount != null)
                    hash = hash * 59 + this.DeactivatedCount.GetHashCode();
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
