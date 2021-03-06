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
    /// ParseExpressionResponseErrors
    /// </summary>
    [DataContract]
    public partial class ParseExpressionResponseErrors :  IEquatable<ParseExpressionResponseErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseExpressionResponseErrors" /> class.
        /// </summary>
        /// <param name="Message">Message.</param>
        /// <param name="Line">Line.</param>
        /// <param name="PosInLine">PosInLine.</param>
        /// <param name="Offset">Offset.</param>
        public ParseExpressionResponseErrors(string Message = default(string), int? Line = default(int?), int? PosInLine = default(int?), int? Offset = default(int?))
        {
            this.Message = Message;
            this.Line = Line;
            this.PosInLine = PosInLine;
            this.Offset = Offset;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public int? Line { get; set; }

        /// <summary>
        /// Gets or Sets PosInLine
        /// </summary>
        [DataMember(Name="posInLine", EmitDefaultValue=false)]
        public int? PosInLine { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseExpressionResponseErrors {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  PosInLine: ").Append(PosInLine).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(input as ParseExpressionResponseErrors);
        }

        /// <summary>
        /// Returns true if ParseExpressionResponseErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of ParseExpressionResponseErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseExpressionResponseErrors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.PosInLine == input.PosInLine ||
                    (this.PosInLine != null &&
                    this.PosInLine.Equals(input.PosInLine))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.PosInLine != null)
                    hashCode = hashCode * 59 + this.PosInLine.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
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
