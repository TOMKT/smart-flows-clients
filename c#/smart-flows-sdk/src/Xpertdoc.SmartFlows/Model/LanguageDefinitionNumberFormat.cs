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
    /// LanguageDefinitionNumberFormat
    /// </summary>
    [DataContract]
    public partial class LanguageDefinitionNumberFormat :  IEquatable<LanguageDefinitionNumberFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDefinitionNumberFormat" /> class.
        /// </summary>
        /// <param name="GroupingSeparator">GroupingSeparator.</param>
        /// <param name="DecimalSeparator">DecimalSeparator.</param>
        /// <param name="Sample">Sample.</param>
        public LanguageDefinitionNumberFormat(string GroupingSeparator = default(string), string DecimalSeparator = default(string), string Sample = default(string))
        {
            this.GroupingSeparator = GroupingSeparator;
            this.DecimalSeparator = DecimalSeparator;
            this.Sample = Sample;
        }
        
        /// <summary>
        /// Gets or Sets GroupingSeparator
        /// </summary>
        [DataMember(Name="groupingSeparator", EmitDefaultValue=false)]
        public string GroupingSeparator { get; set; }

        /// <summary>
        /// Gets or Sets DecimalSeparator
        /// </summary>
        [DataMember(Name="decimalSeparator", EmitDefaultValue=false)]
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Gets or Sets Sample
        /// </summary>
        [DataMember(Name="sample", EmitDefaultValue=false)]
        public string Sample { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguageDefinitionNumberFormat {\n");
            sb.Append("  GroupingSeparator: ").Append(GroupingSeparator).Append("\n");
            sb.Append("  DecimalSeparator: ").Append(DecimalSeparator).Append("\n");
            sb.Append("  Sample: ").Append(Sample).Append("\n");
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
            return this.Equals(input as LanguageDefinitionNumberFormat);
        }

        /// <summary>
        /// Returns true if LanguageDefinitionNumberFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguageDefinitionNumberFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguageDefinitionNumberFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupingSeparator == input.GroupingSeparator ||
                    (this.GroupingSeparator != null &&
                    this.GroupingSeparator.Equals(input.GroupingSeparator))
                ) && 
                (
                    this.DecimalSeparator == input.DecimalSeparator ||
                    (this.DecimalSeparator != null &&
                    this.DecimalSeparator.Equals(input.DecimalSeparator))
                ) && 
                (
                    this.Sample == input.Sample ||
                    (this.Sample != null &&
                    this.Sample.Equals(input.Sample))
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
                if (this.GroupingSeparator != null)
                    hashCode = hashCode * 59 + this.GroupingSeparator.GetHashCode();
                if (this.DecimalSeparator != null)
                    hashCode = hashCode * 59 + this.DecimalSeparator.GetHashCode();
                if (this.Sample != null)
                    hashCode = hashCode * 59 + this.Sample.GetHashCode();
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
