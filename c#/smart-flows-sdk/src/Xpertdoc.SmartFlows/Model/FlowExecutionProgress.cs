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
    /// FlowExecutionProgress
    /// </summary>
    [DataContract]
    public partial class FlowExecutionProgress :  IEquatable<FlowExecutionProgress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowExecutionProgress" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Percentage">Percentage.</param>
        /// <param name="CurrentData">CurrentData.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="Model">Model.</param>
        /// <param name="Form">Form.</param>
        public FlowExecutionProgress(string Id = default(string), int? Percentage = default(int?), IdWithName CurrentData = default(IdWithName), string Message = default(string), FlowExecutionStatus Status = default(FlowExecutionStatus), Object Schema = default(Object), Object Model = default(Object), List<Object> Form = default(List<Object>))
        {
            this.Id = Id;
            this.Percentage = Percentage;
            this.CurrentData = CurrentData;
            this.Message = Message;
            this.Status = Status;
            this.Schema = Schema;
            this.Model = Model;
            this.Form = Form;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// Gets or Sets CurrentData
        /// </summary>
        [DataMember(Name="currentData", EmitDefaultValue=false)]
        public IdWithName CurrentData { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public FlowExecutionStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Object Schema { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public Object Model { get; set; }

        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public List<Object> Form { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecutionProgress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  CurrentData: ").Append(CurrentData).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
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
            return this.Equals(input as FlowExecutionProgress);
        }

        /// <summary>
        /// Returns true if FlowExecutionProgress instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowExecutionProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowExecutionProgress input)
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
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
                ) && 
                (
                    this.CurrentData == input.CurrentData ||
                    (this.CurrentData != null &&
                    this.CurrentData.Equals(input.CurrentData))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Form == input.Form ||
                    this.Form != null &&
                    this.Form.SequenceEqual(input.Form)
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
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.CurrentData != null)
                    hashCode = hashCode * 59 + this.CurrentData.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
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
            // Percentage (int?) maximum
            if(this.Percentage > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value less than or equal to 100.", new [] { "Percentage" });
            }

            // Percentage (int?) minimum
            if(this.Percentage < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value greater than or equal to 0.", new [] { "Percentage" });
            }

            yield break;
        }
    }

}