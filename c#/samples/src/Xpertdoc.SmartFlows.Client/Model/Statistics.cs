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
    /// Statistics
    /// </summary>
    [DataContract]
    public partial class Statistics :  IEquatable<Statistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Statistics" /> class.
        /// </summary>
        /// <param name="PerTime">PerTime.</param>
        /// <param name="PerObject">PerObject.</param>
        /// <param name="PerUser">PerUser.</param>
        public Statistics(List<StatisticsPerTime> PerTime = default(List<StatisticsPerTime>), List<StatisticsPerObject> PerObject = default(List<StatisticsPerObject>), List<StatisticsPerUser> PerUser = default(List<StatisticsPerUser>))
        {
            this.PerTime = PerTime;
            this.PerObject = PerObject;
            this.PerUser = PerUser;
        }
        
        /// <summary>
        /// Gets or Sets PerTime
        /// </summary>
        [DataMember(Name="perTime", EmitDefaultValue=false)]
        public List<StatisticsPerTime> PerTime { get; set; }

        /// <summary>
        /// Gets or Sets PerObject
        /// </summary>
        [DataMember(Name="perObject", EmitDefaultValue=false)]
        public List<StatisticsPerObject> PerObject { get; set; }

        /// <summary>
        /// Gets or Sets PerUser
        /// </summary>
        [DataMember(Name="perUser", EmitDefaultValue=false)]
        public List<StatisticsPerUser> PerUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistics {\n");
            sb.Append("  PerTime: ").Append(PerTime).Append("\n");
            sb.Append("  PerObject: ").Append(PerObject).Append("\n");
            sb.Append("  PerUser: ").Append(PerUser).Append("\n");
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
            return this.Equals(obj as Statistics);
        }

        /// <summary>
        /// Returns true if Statistics instances are equal
        /// </summary>
        /// <param name="other">Instance of Statistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statistics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PerTime == other.PerTime ||
                    this.PerTime != null &&
                    this.PerTime.SequenceEqual(other.PerTime)
                ) && 
                (
                    this.PerObject == other.PerObject ||
                    this.PerObject != null &&
                    this.PerObject.SequenceEqual(other.PerObject)
                ) && 
                (
                    this.PerUser == other.PerUser ||
                    this.PerUser != null &&
                    this.PerUser.SequenceEqual(other.PerUser)
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
                if (this.PerTime != null)
                    hash = hash * 59 + this.PerTime.GetHashCode();
                if (this.PerObject != null)
                    hash = hash * 59 + this.PerObject.GetHashCode();
                if (this.PerUser != null)
                    hash = hash * 59 + this.PerUser.GetHashCode();
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
