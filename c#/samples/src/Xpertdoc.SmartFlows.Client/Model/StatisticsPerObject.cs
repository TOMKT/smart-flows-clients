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
    /// StatisticsPerObject
    /// </summary>
    [DataContract]
    public partial class StatisticsPerObject :  IEquatable<StatisticsPerObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsPerObject" /> class.
        /// </summary>
        /// <param name="_Object">_Object.</param>
        /// <param name="Count">Count.</param>
        /// <param name="Percentage">Percentage.</param>
        public StatisticsPerObject(IdWithName _Object = default(IdWithName), int? Count = default(int?), int? Percentage = default(int?))
        {
            this._Object = _Object;
            this.Count = Count;
            this.Percentage = Percentage;
        }
        
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public IdWithName _Object { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public int? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticsPerObject {\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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
            return this.Equals(obj as StatisticsPerObject);
        }

        /// <summary>
        /// Returns true if StatisticsPerObject instances are equal
        /// </summary>
        /// <param name="other">Instance of StatisticsPerObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticsPerObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
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
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
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
            // Count (int?) minimum
            if(this.Count < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to 0.", new [] { "Count" });
            }

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