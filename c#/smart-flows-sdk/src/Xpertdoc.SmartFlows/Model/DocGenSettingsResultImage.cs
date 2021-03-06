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
    /// DocGenSettingsResultImage
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultImage :  IEquatable<DocGenSettingsResultImage>, IValidatableObject
    {
        /// <summary>
        /// Defines Format
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Png for value: png
            /// </summary>
            [EnumMember(Value = "png")]
            Png = 1,
            
            /// <summary>
            /// Enum Jpeg for value: jpeg
            /// </summary>
            [EnumMember(Value = "jpeg")]
            Jpeg = 2,
            
            /// <summary>
            /// Enum Svg for value: svg
            /// </summary>
            [EnumMember(Value = "svg")]
            Svg = 3,
            
            /// <summary>
            /// Enum Bmp for value: bmp
            /// </summary>
            [EnumMember(Value = "bmp")]
            Bmp = 4,
            
            /// <summary>
            /// Enum Gif for value: gif
            /// </summary>
            [EnumMember(Value = "gif")]
            Gif = 5,
            
            /// <summary>
            /// Enum Emf for value: emf
            /// </summary>
            [EnumMember(Value = "emf")]
            Emf = 6
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black
        /// </summary>
        /// <value>How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorModeEnum
        {
            
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,
            
            /// <summary>
            /// Enum BlackAndWhite for value: blackAndWhite
            /// </summary>
            [EnumMember(Value = "blackAndWhite")]
            BlackAndWhite = 2,
            
            /// <summary>
            /// Enum Grayscale for value: grayscale
            /// </summary>
            [EnumMember(Value = "grayscale")]
            Grayscale = 3
        }

        /// <summary>
        /// How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black
        /// </summary>
        /// <value>How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black</value>
        [DataMember(Name="colorMode", EmitDefaultValue=false)]
        public ColorModeEnum? ColorMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultImage" /> class.
        /// </summary>
        /// <param name="Pageing">Pageing.</param>
        /// <param name="Format">Format (default to FormatEnum.Png).</param>
        /// <param name="AntiAliasing">Whether or not to use anti-aliasing for rendering (default to true).</param>
        /// <param name="ColorMode">How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black (default to ColorModeEnum.Normal).</param>
        /// <param name="Resolution">Specifies the output resolution for images in dpi.</param>
        /// <param name="PaperColor">The background (paper) color for the generated images. When rendering pages of a document that specifies its own background color, then the document background color will override the color specified by this property (default to &quot;white&quot;).</param>
        /// <param name="Scale">The zoom factor for the generated images.</param>
        /// <param name="JpegQuality">The quality of JPEG images. 0 means worst quality but maximum compression and 100 means best quality but minimum compression. If quality is 100, it means no compression.</param>
        public DocGenSettingsResultImage(DocGenSettingsResultImagePageing Pageing = default(DocGenSettingsResultImagePageing), FormatEnum? Format = FormatEnum.Png, bool? AntiAliasing = true, ColorModeEnum? ColorMode = ColorModeEnum.Normal, int? Resolution = default(int?), string PaperColor = "white", decimal? Scale = default(decimal?), int? JpegQuality = default(int?))
        {
            this.Pageing = Pageing;
            // use default value if no "Format" provided
            if (Format == null)
            {
                this.Format = FormatEnum.Png;
            }
            else
            {
                this.Format = Format;
            }
            // use default value if no "AntiAliasing" provided
            if (AntiAliasing == null)
            {
                this.AntiAliasing = true;
            }
            else
            {
                this.AntiAliasing = AntiAliasing;
            }
            // use default value if no "ColorMode" provided
            if (ColorMode == null)
            {
                this.ColorMode = ColorModeEnum.Normal;
            }
            else
            {
                this.ColorMode = ColorMode;
            }
            this.Resolution = Resolution;
            // use default value if no "PaperColor" provided
            if (PaperColor == null)
            {
                this.PaperColor = "white";
            }
            else
            {
                this.PaperColor = PaperColor;
            }
            this.Scale = Scale;
            this.JpegQuality = JpegQuality;
        }
        
        /// <summary>
        /// Gets or Sets Pageing
        /// </summary>
        [DataMember(Name="pageing", EmitDefaultValue=false)]
        public DocGenSettingsResultImagePageing Pageing { get; set; }


        /// <summary>
        /// Whether or not to use anti-aliasing for rendering
        /// </summary>
        /// <value>Whether or not to use anti-aliasing for rendering</value>
        [DataMember(Name="antiAliasing", EmitDefaultValue=false)]
        public bool? AntiAliasing { get; set; }


        /// <summary>
        /// Specifies the output resolution for images in dpi
        /// </summary>
        /// <value>Specifies the output resolution for images in dpi</value>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public int? Resolution { get; set; }

        /// <summary>
        /// The background (paper) color for the generated images. When rendering pages of a document that specifies its own background color, then the document background color will override the color specified by this property
        /// </summary>
        /// <value>The background (paper) color for the generated images. When rendering pages of a document that specifies its own background color, then the document background color will override the color specified by this property</value>
        [DataMember(Name="paperColor", EmitDefaultValue=false)]
        public string PaperColor { get; set; }

        /// <summary>
        /// The zoom factor for the generated images
        /// </summary>
        /// <value>The zoom factor for the generated images</value>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public decimal? Scale { get; set; }

        /// <summary>
        /// The quality of JPEG images. 0 means worst quality but maximum compression and 100 means best quality but minimum compression. If quality is 100, it means no compression
        /// </summary>
        /// <value>The quality of JPEG images. 0 means worst quality but maximum compression and 100 means best quality but minimum compression. If quality is 100, it means no compression</value>
        [DataMember(Name="jpegQuality", EmitDefaultValue=false)]
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultImage {\n");
            sb.Append("  Pageing: ").Append(Pageing).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  AntiAliasing: ").Append(AntiAliasing).Append("\n");
            sb.Append("  ColorMode: ").Append(ColorMode).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  PaperColor: ").Append(PaperColor).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
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
            return this.Equals(input as DocGenSettingsResultImage);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultImage instances are equal
        /// </summary>
        /// <param name="input">Instance of DocGenSettingsResultImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pageing == input.Pageing ||
                    (this.Pageing != null &&
                    this.Pageing.Equals(input.Pageing))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.AntiAliasing == input.AntiAliasing ||
                    (this.AntiAliasing != null &&
                    this.AntiAliasing.Equals(input.AntiAliasing))
                ) && 
                (
                    this.ColorMode == input.ColorMode ||
                    (this.ColorMode != null &&
                    this.ColorMode.Equals(input.ColorMode))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.PaperColor == input.PaperColor ||
                    (this.PaperColor != null &&
                    this.PaperColor.Equals(input.PaperColor))
                ) && 
                (
                    this.Scale == input.Scale ||
                    (this.Scale != null &&
                    this.Scale.Equals(input.Scale))
                ) && 
                (
                    this.JpegQuality == input.JpegQuality ||
                    (this.JpegQuality != null &&
                    this.JpegQuality.Equals(input.JpegQuality))
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
                if (this.Pageing != null)
                    hashCode = hashCode * 59 + this.Pageing.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.AntiAliasing != null)
                    hashCode = hashCode * 59 + this.AntiAliasing.GetHashCode();
                if (this.ColorMode != null)
                    hashCode = hashCode * 59 + this.ColorMode.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.PaperColor != null)
                    hashCode = hashCode * 59 + this.PaperColor.GetHashCode();
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                if (this.JpegQuality != null)
                    hashCode = hashCode * 59 + this.JpegQuality.GetHashCode();
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
            // Resolution (int?) minimum
            if(this.Resolution < (int?)72)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Resolution, must be a value greater than or equal to 72.", new [] { "Resolution" });
            }

            // JpegQuality (int?) maximum
            if(this.JpegQuality > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JpegQuality, must be a value less than or equal to 100.", new [] { "JpegQuality" });
            }

            // JpegQuality (int?) minimum
            if(this.JpegQuality < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JpegQuality, must be a value greater than or equal to 0.", new [] { "JpegQuality" });
            }

            yield break;
        }
    }

}
