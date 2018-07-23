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
    /// PrinterProperties
    /// </summary>
    [DataContract]
    public partial class PrinterProperties :  IEquatable<PrinterProperties>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterProperties" /> class.
        /// </summary>
        /// <param name="General">General.</param>
        /// <param name="Jps">Jps.</param>
        /// <param name="Gcp">Gcp.</param>
        public PrinterProperties(GeneralPrintProps General = default(GeneralPrintProps), JpsPrintProps Jps = default(JpsPrintProps), GcpPrintProps Gcp = default(GcpPrintProps))
        {
            this.General = General;
            this.Jps = Jps;
            this.Gcp = Gcp;
        }
        
        /// <summary>
        /// Gets or Sets General
        /// </summary>
        [DataMember(Name="general", EmitDefaultValue=false)]
        public GeneralPrintProps General { get; set; }

        /// <summary>
        /// Gets or Sets Jps
        /// </summary>
        [DataMember(Name="jps", EmitDefaultValue=false)]
        public JpsPrintProps Jps { get; set; }

        /// <summary>
        /// Gets or Sets Gcp
        /// </summary>
        [DataMember(Name="gcp", EmitDefaultValue=false)]
        public GcpPrintProps Gcp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterProperties {\n");
            sb.Append("  General: ").Append(General).Append("\n");
            sb.Append("  Jps: ").Append(Jps).Append("\n");
            sb.Append("  Gcp: ").Append(Gcp).Append("\n");
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
            return this.Equals(obj as PrinterProperties);
        }

        /// <summary>
        /// Returns true if PrinterProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of PrinterProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.General == other.General ||
                    this.General != null &&
                    this.General.Equals(other.General)
                ) && 
                (
                    this.Jps == other.Jps ||
                    this.Jps != null &&
                    this.Jps.Equals(other.Jps)
                ) && 
                (
                    this.Gcp == other.Gcp ||
                    this.Gcp != null &&
                    this.Gcp.Equals(other.Gcp)
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
                if (this.General != null)
                    hash = hash * 59 + this.General.GetHashCode();
                if (this.Jps != null)
                    hash = hash * 59 + this.Jps.GetHashCode();
                if (this.Gcp != null)
                    hash = hash * 59 + this.Gcp.GetHashCode();
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
