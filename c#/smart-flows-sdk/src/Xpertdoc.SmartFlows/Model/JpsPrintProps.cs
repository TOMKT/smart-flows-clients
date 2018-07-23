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
    /// JpsPrintProps
    /// </summary>
    [DataContract]
    public partial class JpsPrintProps :  IEquatable<JpsPrintProps>, IValidatableObject
    {
        /// <summary>
        /// Defines Duplexing
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DuplexingEnum
        {
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            
            /// <summary>
            /// Enum OneSided for value: oneSided
            /// </summary>
            [EnumMember(Value = "oneSided")]
            OneSided = 2,
            
            /// <summary>
            /// Enum TwoSidedLongEdge for value: twoSidedLongEdge
            /// </summary>
            [EnumMember(Value = "twoSidedLongEdge")]
            TwoSidedLongEdge = 3,
            
            /// <summary>
            /// Enum TwoSidedShortEdge for value: twoSidedShortEdge
            /// </summary>
            [EnumMember(Value = "twoSidedShortEdge")]
            TwoSidedShortEdge = 4
        }

        /// <summary>
        /// Gets or Sets Duplexing
        /// </summary>
        [DataMember(Name="duplexing", EmitDefaultValue=false)]
        public DuplexingEnum? Duplexing { get; set; }
        /// <summary>
        /// Defines Collate
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CollateEnum
        {
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            
            /// <summary>
            /// Enum True for value: true
            /// </summary>
            [EnumMember(Value = "true")]
            True = 2,
            
            /// <summary>
            /// Enum False for value: false
            /// </summary>
            [EnumMember(Value = "false")]
            False = 3
        }

        /// <summary>
        /// Gets or Sets Collate
        /// </summary>
        [DataMember(Name="collate", EmitDefaultValue=false)]
        public CollateEnum? Collate { get; set; }
        /// <summary>
        /// Defines Chromaticity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChromaticityEnum
        {
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            
            /// <summary>
            /// Enum Monochrome for value: monochrome
            /// </summary>
            [EnumMember(Value = "monochrome")]
            Monochrome = 2,
            
            /// <summary>
            /// Enum Color for value: color
            /// </summary>
            [EnumMember(Value = "color")]
            Color = 3
        }

        /// <summary>
        /// Gets or Sets Chromaticity
        /// </summary>
        [DataMember(Name="chromaticity", EmitDefaultValue=false)]
        public ChromaticityEnum? Chromaticity { get; set; }
        /// <summary>
        /// Defines Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,
            
            /// <summary>
            /// Enum Portrait for value: portrait
            /// </summary>
            [EnumMember(Value = "portrait")]
            Portrait = 2,
            
            /// <summary>
            /// Enum Landscape for value: landscape
            /// </summary>
            [EnumMember(Value = "landscape")]
            Landscape = 3
        }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OrientationEnum? Orientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JpsPrintProps" /> class.
        /// </summary>
        /// <param name="Duplexing">Duplexing.</param>
        /// <param name="Collate">Collate.</param>
        /// <param name="Chromaticity">Chromaticity.</param>
        /// <param name="Orientation">Orientation.</param>
        /// <param name="PaperSource">PaperSource.</param>
        /// <param name="FirstPagePaperSource">FirstPagePaperSource.</param>
        /// <param name="PaperSize">PaperSize.</param>
        public JpsPrintProps(DuplexingEnum? Duplexing = default(DuplexingEnum?), CollateEnum? Collate = default(CollateEnum?), ChromaticityEnum? Chromaticity = default(ChromaticityEnum?), OrientationEnum? Orientation = default(OrientationEnum?), string PaperSource = default(string), string FirstPagePaperSource = default(string), string PaperSize = default(string))
        {
            this.Duplexing = Duplexing;
            this.Collate = Collate;
            this.Chromaticity = Chromaticity;
            this.Orientation = Orientation;
            this.PaperSource = PaperSource;
            this.FirstPagePaperSource = FirstPagePaperSource;
            this.PaperSize = PaperSize;
        }
        




        /// <summary>
        /// Gets or Sets PaperSource
        /// </summary>
        [DataMember(Name="paperSource", EmitDefaultValue=false)]
        public string PaperSource { get; set; }

        /// <summary>
        /// Gets or Sets FirstPagePaperSource
        /// </summary>
        [DataMember(Name="firstPagePaperSource", EmitDefaultValue=false)]
        public string FirstPagePaperSource { get; set; }

        /// <summary>
        /// Gets or Sets PaperSize
        /// </summary>
        [DataMember(Name="paperSize", EmitDefaultValue=false)]
        public string PaperSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JpsPrintProps {\n");
            sb.Append("  Duplexing: ").Append(Duplexing).Append("\n");
            sb.Append("  Collate: ").Append(Collate).Append("\n");
            sb.Append("  Chromaticity: ").Append(Chromaticity).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  PaperSource: ").Append(PaperSource).Append("\n");
            sb.Append("  FirstPagePaperSource: ").Append(FirstPagePaperSource).Append("\n");
            sb.Append("  PaperSize: ").Append(PaperSize).Append("\n");
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
            return this.Equals(input as JpsPrintProps);
        }

        /// <summary>
        /// Returns true if JpsPrintProps instances are equal
        /// </summary>
        /// <param name="input">Instance of JpsPrintProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JpsPrintProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duplexing == input.Duplexing ||
                    (this.Duplexing != null &&
                    this.Duplexing.Equals(input.Duplexing))
                ) && 
                (
                    this.Collate == input.Collate ||
                    (this.Collate != null &&
                    this.Collate.Equals(input.Collate))
                ) && 
                (
                    this.Chromaticity == input.Chromaticity ||
                    (this.Chromaticity != null &&
                    this.Chromaticity.Equals(input.Chromaticity))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.PaperSource == input.PaperSource ||
                    (this.PaperSource != null &&
                    this.PaperSource.Equals(input.PaperSource))
                ) && 
                (
                    this.FirstPagePaperSource == input.FirstPagePaperSource ||
                    (this.FirstPagePaperSource != null &&
                    this.FirstPagePaperSource.Equals(input.FirstPagePaperSource))
                ) && 
                (
                    this.PaperSize == input.PaperSize ||
                    (this.PaperSize != null &&
                    this.PaperSize.Equals(input.PaperSize))
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
                if (this.Duplexing != null)
                    hashCode = hashCode * 59 + this.Duplexing.GetHashCode();
                if (this.Collate != null)
                    hashCode = hashCode * 59 + this.Collate.GetHashCode();
                if (this.Chromaticity != null)
                    hashCode = hashCode * 59 + this.Chromaticity.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.PaperSource != null)
                    hashCode = hashCode * 59 + this.PaperSource.GetHashCode();
                if (this.FirstPagePaperSource != null)
                    hashCode = hashCode * 59 + this.FirstPagePaperSource.GetHashCode();
                if (this.PaperSize != null)
                    hashCode = hashCode * 59 + this.PaperSize.GetHashCode();
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
