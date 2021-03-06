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
    /// DocGenSettingsResultOoxml
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultOoxml :  IEquatable<DocGenSettingsResultOoxml>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Docx for "docx"
            /// </summary>
            [EnumMember(Value = "docx")]
            Docx,
            
            /// <summary>
            /// Enum Dotx for "dotx"
            /// </summary>
            [EnumMember(Value = "dotx")]
            Dotx,
            
            /// <summary>
            /// Enum Docm for "docm"
            /// </summary>
            [EnumMember(Value = "docm")]
            Docm,
            
            /// <summary>
            /// Enum Dotm for "dotm"
            /// </summary>
            [EnumMember(Value = "dotm")]
            Dotm,
            
            /// <summary>
            /// Enum Flatopc for "flatopc"
            /// </summary>
            [EnumMember(Value = "flatopc")]
            Flatopc
        }

        /// <summary>
        /// Gets or Sets Compliance
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceEnum
        {
            
            /// <summary>
            /// Enum Iso295002008strict for "iso_29500_2008_strict"
            /// </summary>
            [EnumMember(Value = "iso_29500_2008_strict")]
            Iso295002008strict,
            
            /// <summary>
            /// Enum Ecma3762006 for "ecma_376_2006"
            /// </summary>
            [EnumMember(Value = "ecma_376_2006")]
            Ecma3762006,
            
            /// <summary>
            /// Enum Iso295002008transitional for "iso_29500_2008_transitional"
            /// </summary>
            [EnumMember(Value = "iso_29500_2008_transitional")]
            Iso295002008transitional
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Gets or Sets Compliance
        /// </summary>
        [DataMember(Name="compliance", EmitDefaultValue=false)]
        public ComplianceEnum? Compliance { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultOoxml" /> class.
        /// </summary>
        /// <param name="Format">Format.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Compliance">Compliance (default to ComplianceEnum.Ecma3762006).</param>
        public DocGenSettingsResultOoxml(FormatEnum? Format = default(FormatEnum?), string Password = default(string), ComplianceEnum? Compliance = ComplianceEnum.Ecma3762006)
        {
            this.Format = Format;
            this.Password = Password;
            // use default value if no "Compliance" provided
            if (Compliance == null)
            {
                this.Compliance = ComplianceEnum.Ecma3762006;
            }
            else
            {
                this.Compliance = Compliance;
            }
        }
        

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultOoxml {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Compliance: ").Append(Compliance).Append("\n");
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
            return this.Equals(obj as DocGenSettingsResultOoxml);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultOoxml instances are equal
        /// </summary>
        /// <param name="other">Instance of DocGenSettingsResultOoxml to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultOoxml other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Compliance == other.Compliance ||
                    this.Compliance != null &&
                    this.Compliance.Equals(other.Compliance)
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
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Compliance != null)
                    hash = hash * 59 + this.Compliance.GetHashCode();
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
