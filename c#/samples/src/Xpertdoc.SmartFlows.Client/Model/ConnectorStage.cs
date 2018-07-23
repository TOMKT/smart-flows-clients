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
    /// ConnectorStage
    /// </summary>
    [DataContract]
    public partial class ConnectorStage :  IEquatable<ConnectorStage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorStage" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Schema">Schema.</param>
        /// <param name="Model">Model.</param>
        /// <param name="Form">Form.</param>
        /// <param name="HasNext">HasNext.</param>
        /// <param name="NextDisabled">NextDisabled.</param>
        /// <param name="HasPrevious">HasPrevious.</param>
        /// <param name="CanFinish">CanFinish.</param>
        public ConnectorStage(string Id = default(string), string Title = default(string), string Description = default(string), Object Schema = default(Object), Object Model = default(Object), List<Object> Form = default(List<Object>), bool? HasNext = default(bool?), string NextDisabled = default(string), bool? HasPrevious = default(bool?), bool? CanFinish = default(bool?))
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Schema = Schema;
            this.Model = Model;
            this.Form = Form;
            this.HasNext = HasNext;
            this.NextDisabled = NextDisabled;
            this.HasPrevious = HasPrevious;
            this.CanFinish = CanFinish;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
        /// Gets or Sets HasNext
        /// </summary>
        [DataMember(Name="hasNext", EmitDefaultValue=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// Gets or Sets NextDisabled
        /// </summary>
        [DataMember(Name="nextDisabled", EmitDefaultValue=false)]
        public string NextDisabled { get; set; }

        /// <summary>
        /// Gets or Sets HasPrevious
        /// </summary>
        [DataMember(Name="hasPrevious", EmitDefaultValue=false)]
        public bool? HasPrevious { get; set; }

        /// <summary>
        /// Gets or Sets CanFinish
        /// </summary>
        [DataMember(Name="canFinish", EmitDefaultValue=false)]
        public bool? CanFinish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorStage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
            sb.Append("  NextDisabled: ").Append(NextDisabled).Append("\n");
            sb.Append("  HasPrevious: ").Append(HasPrevious).Append("\n");
            sb.Append("  CanFinish: ").Append(CanFinish).Append("\n");
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
            return this.Equals(obj as ConnectorStage);
        }

        /// <summary>
        /// Returns true if ConnectorStage instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectorStage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorStage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Form == other.Form ||
                    this.Form != null &&
                    this.Form.SequenceEqual(other.Form)
                ) && 
                (
                    this.HasNext == other.HasNext ||
                    this.HasNext != null &&
                    this.HasNext.Equals(other.HasNext)
                ) && 
                (
                    this.NextDisabled == other.NextDisabled ||
                    this.NextDisabled != null &&
                    this.NextDisabled.Equals(other.NextDisabled)
                ) && 
                (
                    this.HasPrevious == other.HasPrevious ||
                    this.HasPrevious != null &&
                    this.HasPrevious.Equals(other.HasPrevious)
                ) && 
                (
                    this.CanFinish == other.CanFinish ||
                    this.CanFinish != null &&
                    this.CanFinish.Equals(other.CanFinish)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.Form != null)
                    hash = hash * 59 + this.Form.GetHashCode();
                if (this.HasNext != null)
                    hash = hash * 59 + this.HasNext.GetHashCode();
                if (this.NextDisabled != null)
                    hash = hash * 59 + this.NextDisabled.GetHashCode();
                if (this.HasPrevious != null)
                    hash = hash * 59 + this.HasPrevious.GetHashCode();
                if (this.CanFinish != null)
                    hash = hash * 59 + this.CanFinish.GetHashCode();
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
