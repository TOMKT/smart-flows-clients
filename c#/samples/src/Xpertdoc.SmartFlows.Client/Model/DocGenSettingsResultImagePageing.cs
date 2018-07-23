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
    /// DocGenSettingsResultImagePageing
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultImagePageing :  IEquatable<DocGenSettingsResultImagePageing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultImagePageing" /> class.
        /// </summary>
        /// <param name="FirstPageIndex">The index of the first page to render (zero-based index).</param>
        /// <param name="PageCount">The number of pages to render.</param>
        public DocGenSettingsResultImagePageing(int? FirstPageIndex = default(int?), int? PageCount = default(int?))
        {
            this.FirstPageIndex = FirstPageIndex;
            this.PageCount = PageCount;
        }
        
        /// <summary>
        /// The index of the first page to render (zero-based index)
        /// </summary>
        /// <value>The index of the first page to render (zero-based index)</value>
        [DataMember(Name="firstPageIndex", EmitDefaultValue=false)]
        public int? FirstPageIndex { get; set; }

        /// <summary>
        /// The number of pages to render
        /// </summary>
        /// <value>The number of pages to render</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultImagePageing {\n");
            sb.Append("  FirstPageIndex: ").Append(FirstPageIndex).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
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
            return this.Equals(obj as DocGenSettingsResultImagePageing);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultImagePageing instances are equal
        /// </summary>
        /// <param name="other">Instance of DocGenSettingsResultImagePageing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultImagePageing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstPageIndex == other.FirstPageIndex ||
                    this.FirstPageIndex != null &&
                    this.FirstPageIndex.Equals(other.FirstPageIndex)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
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
                if (this.FirstPageIndex != null)
                    hash = hash * 59 + this.FirstPageIndex.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
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
            // FirstPageIndex (int?) minimum
            if(this.FirstPageIndex < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstPageIndex, must be a value greater than or equal to 0.", new [] { "FirstPageIndex" });
            }

            // PageCount (int?) minimum
            if(this.PageCount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageCount, must be a value greater than or equal to 1.", new [] { "PageCount" });
            }

            yield break;
        }
    }

}
