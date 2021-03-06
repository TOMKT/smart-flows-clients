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
    /// ConditionValue
    /// </summary>
    [DataContract]
    public partial class ConditionValue :  IEquatable<ConditionValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionValue" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Type">Type.</param>
        /// <param name="DocPropName">DocPropName.</param>
        /// <param name="Constant">Constant.</param>
        /// <param name="Field">Field.</param>
        /// <param name="Expression">Expression.</param>
        /// <param name="FlowVariable">FlowVariable.</param>
        public ConditionValue(string DisplayName = default(string), ConditionValueType Type = default(ConditionValueType), string DocPropName = default(string), string Constant = default(string), string Field = default(string), string Expression = default(string), ConditionFlowVariable FlowVariable = default(ConditionFlowVariable))
        {
            this.DisplayName = DisplayName;
            this.Type = Type;
            this.DocPropName = DocPropName;
            this.Constant = Constant;
            this.Field = Field;
            this.Expression = Expression;
            this.FlowVariable = FlowVariable;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ConditionValueType Type { get; set; }

        /// <summary>
        /// Gets or Sets DocPropName
        /// </summary>
        [DataMember(Name="docPropName", EmitDefaultValue=false)]
        public string DocPropName { get; set; }

        /// <summary>
        /// Gets or Sets Constant
        /// </summary>
        [DataMember(Name="constant", EmitDefaultValue=false)]
        public string Constant { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name="expression", EmitDefaultValue=false)]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or Sets FlowVariable
        /// </summary>
        [DataMember(Name="flowVariable", EmitDefaultValue=false)]
        public ConditionFlowVariable FlowVariable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionValue {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DocPropName: ").Append(DocPropName).Append("\n");
            sb.Append("  Constant: ").Append(Constant).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  FlowVariable: ").Append(FlowVariable).Append("\n");
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
            return this.Equals(input as ConditionValue);
        }

        /// <summary>
        /// Returns true if ConditionValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DocPropName == input.DocPropName ||
                    (this.DocPropName != null &&
                    this.DocPropName.Equals(input.DocPropName))
                ) && 
                (
                    this.Constant == input.Constant ||
                    (this.Constant != null &&
                    this.Constant.Equals(input.Constant))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.FlowVariable == input.FlowVariable ||
                    (this.FlowVariable != null &&
                    this.FlowVariable.Equals(input.FlowVariable))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DocPropName != null)
                    hashCode = hashCode * 59 + this.DocPropName.GetHashCode();
                if (this.Constant != null)
                    hashCode = hashCode * 59 + this.Constant.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.FlowVariable != null)
                    hashCode = hashCode * 59 + this.FlowVariable.GetHashCode();
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
