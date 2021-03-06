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
    /// DocGenSettingsResultHtml
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultHtml :  IEquatable<DocGenSettingsResultHtml>, IValidatableObject
    {
        /// <summary>
        /// Defines Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Epub for value: epub
            /// </summary>
            [EnumMember(Value = "epub")]
            Epub = 1,
            
            /// <summary>
            /// Enum Mhtml for value: mhtml
            /// </summary>
            [EnumMember(Value = "mhtml")]
            Mhtml = 2,
            
            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 3
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section.
        /// </summary>
        /// <value>Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportHeadersFootersEnum
        {
            
            /// <summary>
            /// Enum FirstPageheaderFooterPerSection for value: firstPageheaderFooterPerSection
            /// </summary>
            [EnumMember(Value = "firstPageheaderFooterPerSection")]
            FirstPageheaderFooterPerSection = 1,
            
            /// <summary>
            /// Enum PerSection for value: perSection
            /// </summary>
            [EnumMember(Value = "perSection")]
            PerSection = 2,
            
            /// <summary>
            /// Enum FirstSectionHeaderLastSectionFooter for value: firstSectionHeaderLastSectionFooter
            /// </summary>
            [EnumMember(Value = "firstSectionHeaderLastSectionFooter")]
            FirstSectionHeaderLastSectionFooter = 3,
            
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 4
        }

        /// <summary>
        /// Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section.
        /// </summary>
        /// <value>Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section.</value>
        [DataMember(Name="exportHeadersFooters", EmitDefaultValue=false)]
        public ExportHeadersFootersEnum? ExportHeadersFooters { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultHtml" /> class.
        /// </summary>
        /// <param name="Format">Format (default to FormatEnum.Html).</param>
        /// <param name="Encoding">Specifies the encoding to use (default to &quot;UTF-8&quot;).</param>
        /// <param name="ExportHeadersFooters">Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section. (default to ExportHeadersFootersEnum.PerSection).</param>
        /// <param name="ExportPageMargins">Specifies whether page margins is exported (default to false).</param>
        /// <param name="ExportPageSetup">Specifies whether page setup is exported (default to false).</param>
        /// <param name="ExportTOCPageNumbers">Specifies whether to write page numbers to table of contents (default to false).</param>
        /// <param name="ExportRelativeFontSize">Specifies whether font sizes should be output in relative units (default to false).</param>
        /// <param name="ImageResolution">Specifies the output resolution for images in dpi.</param>
        /// <param name="ExportImagesAsBase64">Specifies whether images are saved in Base64 (default to false).</param>
        /// <param name="MaintainLinkToExternalImages">Specifies whether original URL should be used as the URL of the linked images (default to true).</param>
        /// <param name="ScaleImagesToShapeSize">Specifies whether images are scaled to the bounding shape size when exporting (default to true).</param>
        public DocGenSettingsResultHtml(FormatEnum? Format = FormatEnum.Html, string Encoding = "UTF-8", ExportHeadersFootersEnum? ExportHeadersFooters = ExportHeadersFootersEnum.PerSection, bool? ExportPageMargins = false, bool? ExportPageSetup = false, bool? ExportTOCPageNumbers = false, bool? ExportRelativeFontSize = false, decimal? ImageResolution = default(decimal?), bool? ExportImagesAsBase64 = false, bool? MaintainLinkToExternalImages = true, bool? ScaleImagesToShapeSize = true)
        {
            // use default value if no "Format" provided
            if (Format == null)
            {
                this.Format = FormatEnum.Html;
            }
            else
            {
                this.Format = Format;
            }
            // use default value if no "Encoding" provided
            if (Encoding == null)
            {
                this.Encoding = "UTF-8";
            }
            else
            {
                this.Encoding = Encoding;
            }
            // use default value if no "ExportHeadersFooters" provided
            if (ExportHeadersFooters == null)
            {
                this.ExportHeadersFooters = ExportHeadersFootersEnum.PerSection;
            }
            else
            {
                this.ExportHeadersFooters = ExportHeadersFooters;
            }
            // use default value if no "ExportPageMargins" provided
            if (ExportPageMargins == null)
            {
                this.ExportPageMargins = false;
            }
            else
            {
                this.ExportPageMargins = ExportPageMargins;
            }
            // use default value if no "ExportPageSetup" provided
            if (ExportPageSetup == null)
            {
                this.ExportPageSetup = false;
            }
            else
            {
                this.ExportPageSetup = ExportPageSetup;
            }
            // use default value if no "ExportTOCPageNumbers" provided
            if (ExportTOCPageNumbers == null)
            {
                this.ExportTOCPageNumbers = false;
            }
            else
            {
                this.ExportTOCPageNumbers = ExportTOCPageNumbers;
            }
            // use default value if no "ExportRelativeFontSize" provided
            if (ExportRelativeFontSize == null)
            {
                this.ExportRelativeFontSize = false;
            }
            else
            {
                this.ExportRelativeFontSize = ExportRelativeFontSize;
            }
            this.ImageResolution = ImageResolution;
            // use default value if no "ExportImagesAsBase64" provided
            if (ExportImagesAsBase64 == null)
            {
                this.ExportImagesAsBase64 = false;
            }
            else
            {
                this.ExportImagesAsBase64 = ExportImagesAsBase64;
            }
            // use default value if no "MaintainLinkToExternalImages" provided
            if (MaintainLinkToExternalImages == null)
            {
                this.MaintainLinkToExternalImages = true;
            }
            else
            {
                this.MaintainLinkToExternalImages = MaintainLinkToExternalImages;
            }
            // use default value if no "ScaleImagesToShapeSize" provided
            if (ScaleImagesToShapeSize == null)
            {
                this.ScaleImagesToShapeSize = true;
            }
            else
            {
                this.ScaleImagesToShapeSize = ScaleImagesToShapeSize;
            }
        }
        

        /// <summary>
        /// Specifies the encoding to use
        /// </summary>
        /// <value>Specifies the encoding to use</value>
        [DataMember(Name="encoding", EmitDefaultValue=false)]
        public string Encoding { get; set; }


        /// <summary>
        /// Specifies whether page margins is exported
        /// </summary>
        /// <value>Specifies whether page margins is exported</value>
        [DataMember(Name="exportPageMargins", EmitDefaultValue=false)]
        public bool? ExportPageMargins { get; set; }

        /// <summary>
        /// Specifies whether page setup is exported
        /// </summary>
        /// <value>Specifies whether page setup is exported</value>
        [DataMember(Name="exportPageSetup", EmitDefaultValue=false)]
        public bool? ExportPageSetup { get; set; }

        /// <summary>
        /// Specifies whether to write page numbers to table of contents
        /// </summary>
        /// <value>Specifies whether to write page numbers to table of contents</value>
        [DataMember(Name="exportTOCPageNumbers", EmitDefaultValue=false)]
        public bool? ExportTOCPageNumbers { get; set; }

        /// <summary>
        /// Specifies whether font sizes should be output in relative units
        /// </summary>
        /// <value>Specifies whether font sizes should be output in relative units</value>
        [DataMember(Name="exportRelativeFontSize", EmitDefaultValue=false)]
        public bool? ExportRelativeFontSize { get; set; }

        /// <summary>
        /// Specifies the output resolution for images in dpi
        /// </summary>
        /// <value>Specifies the output resolution for images in dpi</value>
        [DataMember(Name="imageResolution", EmitDefaultValue=false)]
        public decimal? ImageResolution { get; set; }

        /// <summary>
        /// Specifies whether images are saved in Base64
        /// </summary>
        /// <value>Specifies whether images are saved in Base64</value>
        [DataMember(Name="exportImagesAsBase64", EmitDefaultValue=false)]
        public bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Specifies whether original URL should be used as the URL of the linked images
        /// </summary>
        /// <value>Specifies whether original URL should be used as the URL of the linked images</value>
        [DataMember(Name="maintainLinkToExternalImages", EmitDefaultValue=false)]
        public bool? MaintainLinkToExternalImages { get; set; }

        /// <summary>
        /// Specifies whether images are scaled to the bounding shape size when exporting
        /// </summary>
        /// <value>Specifies whether images are scaled to the bounding shape size when exporting</value>
        [DataMember(Name="scaleImagesToShapeSize", EmitDefaultValue=false)]
        public bool? ScaleImagesToShapeSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultHtml {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  ExportHeadersFooters: ").Append(ExportHeadersFooters).Append("\n");
            sb.Append("  ExportPageMargins: ").Append(ExportPageMargins).Append("\n");
            sb.Append("  ExportPageSetup: ").Append(ExportPageSetup).Append("\n");
            sb.Append("  ExportTOCPageNumbers: ").Append(ExportTOCPageNumbers).Append("\n");
            sb.Append("  ExportRelativeFontSize: ").Append(ExportRelativeFontSize).Append("\n");
            sb.Append("  ImageResolution: ").Append(ImageResolution).Append("\n");
            sb.Append("  ExportImagesAsBase64: ").Append(ExportImagesAsBase64).Append("\n");
            sb.Append("  MaintainLinkToExternalImages: ").Append(MaintainLinkToExternalImages).Append("\n");
            sb.Append("  ScaleImagesToShapeSize: ").Append(ScaleImagesToShapeSize).Append("\n");
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
            return this.Equals(input as DocGenSettingsResultHtml);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultHtml instances are equal
        /// </summary>
        /// <param name="input">Instance of DocGenSettingsResultHtml to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultHtml input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    (this.Encoding != null &&
                    this.Encoding.Equals(input.Encoding))
                ) && 
                (
                    this.ExportHeadersFooters == input.ExportHeadersFooters ||
                    (this.ExportHeadersFooters != null &&
                    this.ExportHeadersFooters.Equals(input.ExportHeadersFooters))
                ) && 
                (
                    this.ExportPageMargins == input.ExportPageMargins ||
                    (this.ExportPageMargins != null &&
                    this.ExportPageMargins.Equals(input.ExportPageMargins))
                ) && 
                (
                    this.ExportPageSetup == input.ExportPageSetup ||
                    (this.ExportPageSetup != null &&
                    this.ExportPageSetup.Equals(input.ExportPageSetup))
                ) && 
                (
                    this.ExportTOCPageNumbers == input.ExportTOCPageNumbers ||
                    (this.ExportTOCPageNumbers != null &&
                    this.ExportTOCPageNumbers.Equals(input.ExportTOCPageNumbers))
                ) && 
                (
                    this.ExportRelativeFontSize == input.ExportRelativeFontSize ||
                    (this.ExportRelativeFontSize != null &&
                    this.ExportRelativeFontSize.Equals(input.ExportRelativeFontSize))
                ) && 
                (
                    this.ImageResolution == input.ImageResolution ||
                    (this.ImageResolution != null &&
                    this.ImageResolution.Equals(input.ImageResolution))
                ) && 
                (
                    this.ExportImagesAsBase64 == input.ExportImagesAsBase64 ||
                    (this.ExportImagesAsBase64 != null &&
                    this.ExportImagesAsBase64.Equals(input.ExportImagesAsBase64))
                ) && 
                (
                    this.MaintainLinkToExternalImages == input.MaintainLinkToExternalImages ||
                    (this.MaintainLinkToExternalImages != null &&
                    this.MaintainLinkToExternalImages.Equals(input.MaintainLinkToExternalImages))
                ) && 
                (
                    this.ScaleImagesToShapeSize == input.ScaleImagesToShapeSize ||
                    (this.ScaleImagesToShapeSize != null &&
                    this.ScaleImagesToShapeSize.Equals(input.ScaleImagesToShapeSize))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Encoding != null)
                    hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.ExportHeadersFooters != null)
                    hashCode = hashCode * 59 + this.ExportHeadersFooters.GetHashCode();
                if (this.ExportPageMargins != null)
                    hashCode = hashCode * 59 + this.ExportPageMargins.GetHashCode();
                if (this.ExportPageSetup != null)
                    hashCode = hashCode * 59 + this.ExportPageSetup.GetHashCode();
                if (this.ExportTOCPageNumbers != null)
                    hashCode = hashCode * 59 + this.ExportTOCPageNumbers.GetHashCode();
                if (this.ExportRelativeFontSize != null)
                    hashCode = hashCode * 59 + this.ExportRelativeFontSize.GetHashCode();
                if (this.ImageResolution != null)
                    hashCode = hashCode * 59 + this.ImageResolution.GetHashCode();
                if (this.ExportImagesAsBase64 != null)
                    hashCode = hashCode * 59 + this.ExportImagesAsBase64.GetHashCode();
                if (this.MaintainLinkToExternalImages != null)
                    hashCode = hashCode * 59 + this.MaintainLinkToExternalImages.GetHashCode();
                if (this.ScaleImagesToShapeSize != null)
                    hashCode = hashCode * 59 + this.ScaleImagesToShapeSize.GetHashCode();
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
