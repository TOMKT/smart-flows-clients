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
    /// FlowCondition
    /// </summary>
    [DataContract]
    public partial class FlowCondition :  IEquatable<FlowCondition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowCondition" /> class.
        /// </summary>
        /// <param name="Conditions">Conditions.</param>
        /// <param name="BodyIfTrue">BodyIfTrue.</param>
        /// <param name="BodyIfFalse">BodyIfFalse.</param>
        public FlowCondition(ConditionGroup Conditions = default(ConditionGroup), List<FlowZone> BodyIfTrue = default(List<FlowZone>), List<FlowZone> BodyIfFalse = default(List<FlowZone>))
        {
            this.Conditions = Conditions;
            this.BodyIfTrue = BodyIfTrue;
            this.BodyIfFalse = BodyIfFalse;
        }
        
        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public ConditionGroup Conditions { get; set; }

        /// <summary>
        /// Gets or Sets BodyIfTrue
        /// </summary>
        [DataMember(Name="bodyIfTrue", EmitDefaultValue=false)]
        public List<FlowZone> BodyIfTrue { get; set; }

        /// <summary>
        /// Gets or Sets BodyIfFalse
        /// </summary>
        [DataMember(Name="bodyIfFalse", EmitDefaultValue=false)]
        public List<FlowZone> BodyIfFalse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowCondition {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  BodyIfTrue: ").Append(BodyIfTrue).Append("\n");
            sb.Append("  BodyIfFalse: ").Append(BodyIfFalse).Append("\n");
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
            return this.Equals(input as FlowCondition);
        }

        /// <summary>
        /// Returns true if FlowCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conditions == input.Conditions ||
                    (this.Conditions != null &&
                    this.Conditions.Equals(input.Conditions))
                ) && 
                (
                    this.BodyIfTrue == input.BodyIfTrue ||
                    this.BodyIfTrue != null &&
                    this.BodyIfTrue.SequenceEqual(input.BodyIfTrue)
                ) && 
                (
                    this.BodyIfFalse == input.BodyIfFalse ||
                    this.BodyIfFalse != null &&
                    this.BodyIfFalse.SequenceEqual(input.BodyIfFalse)
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
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.BodyIfTrue != null)
                    hashCode = hashCode * 59 + this.BodyIfTrue.GetHashCode();
                if (this.BodyIfFalse != null)
                    hashCode = hashCode * 59 + this.BodyIfFalse.GetHashCode();
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
