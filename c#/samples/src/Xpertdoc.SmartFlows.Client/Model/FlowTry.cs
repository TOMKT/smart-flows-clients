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
    /// FlowTry
    /// </summary>
    [DataContract]
    public partial class FlowTry :  IEquatable<FlowTry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowTry" /> class.
        /// </summary>
        /// <param name="BodyTry">BodyTry.</param>
        /// <param name="BodyCatch">BodyCatch.</param>
        public FlowTry(List<FlowZone> BodyTry = default(List<FlowZone>), List<FlowZone> BodyCatch = default(List<FlowZone>))
        {
            this.BodyTry = BodyTry;
            this.BodyCatch = BodyCatch;
        }
        
        /// <summary>
        /// Gets or Sets BodyTry
        /// </summary>
        [DataMember(Name="bodyTry", EmitDefaultValue=false)]
        public List<FlowZone> BodyTry { get; set; }

        /// <summary>
        /// Gets or Sets BodyCatch
        /// </summary>
        [DataMember(Name="bodyCatch", EmitDefaultValue=false)]
        public List<FlowZone> BodyCatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowTry {\n");
            sb.Append("  BodyTry: ").Append(BodyTry).Append("\n");
            sb.Append("  BodyCatch: ").Append(BodyCatch).Append("\n");
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
            return this.Equals(obj as FlowTry);
        }

        /// <summary>
        /// Returns true if FlowTry instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowTry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowTry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BodyTry == other.BodyTry ||
                    this.BodyTry != null &&
                    this.BodyTry.SequenceEqual(other.BodyTry)
                ) && 
                (
                    this.BodyCatch == other.BodyCatch ||
                    this.BodyCatch != null &&
                    this.BodyCatch.SequenceEqual(other.BodyCatch)
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
                if (this.BodyTry != null)
                    hash = hash * 59 + this.BodyTry.GetHashCode();
                if (this.BodyCatch != null)
                    hash = hash * 59 + this.BodyCatch.GetHashCode();
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
