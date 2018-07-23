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
    /// The content of the template when type is standard. Content of composed templates is embedded in the template definition below composedContent
    /// </summary>
    [DataContract]
    public partial class TemplateStandardContent :  IEquatable<TemplateStandardContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateStandardContent" /> class.
        /// </summary>
        /// <param name="SupportedLanguages">SupportedLanguages.</param>
        /// <param name="Link">Link to the endpoint that returns the content of the template.</param>
        public TemplateStandardContent(List<string> SupportedLanguages = default(List<string>), string Link = default(string))
        {
            this.SupportedLanguages = SupportedLanguages;
            this.Link = Link;
        }
        
        /// <summary>
        /// Gets or Sets SupportedLanguages
        /// </summary>
        [DataMember(Name="supportedLanguages", EmitDefaultValue=false)]
        public List<string> SupportedLanguages { get; set; }

        /// <summary>
        /// Link to the endpoint that returns the content of the template
        /// </summary>
        /// <value>Link to the endpoint that returns the content of the template</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateStandardContent {\n");
            sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(obj as TemplateStandardContent);
        }

        /// <summary>
        /// Returns true if TemplateStandardContent instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateStandardContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateStandardContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SupportedLanguages == other.SupportedLanguages ||
                    this.SupportedLanguages != null &&
                    this.SupportedLanguages.SequenceEqual(other.SupportedLanguages)
                ) && 
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
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
                if (this.SupportedLanguages != null)
                    hash = hash * 59 + this.SupportedLanguages.GetHashCode();
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
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
