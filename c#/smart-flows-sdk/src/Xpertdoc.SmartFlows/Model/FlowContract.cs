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
    /// FlowContract
    /// </summary>
    [DataContract]
    public partial class FlowContract :  IEquatable<FlowContract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowContract" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="InputSchema">InputSchema.</param>
        /// <param name="OutputSchema">OutputSchema.</param>
        public FlowContract(string Id = default(string), string DisplayName = default(string), string Description = default(string), Object InputSchema = default(Object), Object OutputSchema = default(Object))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.InputSchema = InputSchema;
            this.OutputSchema = OutputSchema;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets InputSchema
        /// </summary>
        [DataMember(Name="inputSchema", EmitDefaultValue=false)]
        public Object InputSchema { get; set; }

        /// <summary>
        /// Gets or Sets OutputSchema
        /// </summary>
        [DataMember(Name="outputSchema", EmitDefaultValue=false)]
        public Object OutputSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowContract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  OutputSchema: ").Append(OutputSchema).Append("\n");
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
            return this.Equals(input as FlowContract);
        }

        /// <summary>
        /// Returns true if FlowContract instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.InputSchema == input.InputSchema ||
                    (this.InputSchema != null &&
                    this.InputSchema.Equals(input.InputSchema))
                ) && 
                (
                    this.OutputSchema == input.OutputSchema ||
                    (this.OutputSchema != null &&
                    this.OutputSchema.Equals(input.OutputSchema))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InputSchema != null)
                    hashCode = hashCode * 59 + this.InputSchema.GetHashCode();
                if (this.OutputSchema != null)
                    hashCode = hashCode * 59 + this.OutputSchema.GetHashCode();
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
