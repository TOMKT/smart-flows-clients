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
    /// DocGenSettingsResultPdfEncryption
    /// </summary>
    [DataContract]
    public partial class DocGenSettingsResultPdfEncryption :  IEquatable<DocGenSettingsResultPdfEncryption>, IValidatableObject
    {
        /// <summary>
        /// The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.
        /// </summary>
        /// <value>The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            
            /// <summary>
            /// Enum _128 for value: rc4_128
            /// </summary>
            [EnumMember(Value = "rc4_128")]
            _128 = 1,
            
            /// <summary>
            /// Enum _40 for value: rc4_40
            /// </summary>
            [EnumMember(Value = "rc4_40")]
            _40 = 2
        }

        /// <summary>
        /// The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.
        /// </summary>
        /// <value>The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// Defines Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsEnum
        {
            
            /// <summary>
            /// Enum DisallowAll for value: disallowAll
            /// </summary>
            [EnumMember(Value = "disallowAll")]
            DisallowAll = 1,
            
            /// <summary>
            /// Enum AllowAll for value: allowAll
            /// </summary>
            [EnumMember(Value = "allowAll")]
            AllowAll = 2,
            
            /// <summary>
            /// Enum ContentCopy for value: contentCopy
            /// </summary>
            [EnumMember(Value = "contentCopy")]
            ContentCopy = 3,
            
            /// <summary>
            /// Enum ContentCopyForAccessibility for value: contentCopyForAccessibility
            /// </summary>
            [EnumMember(Value = "contentCopyForAccessibility")]
            ContentCopyForAccessibility = 4,
            
            /// <summary>
            /// Enum ModifyContents for value: modifyContents
            /// </summary>
            [EnumMember(Value = "modifyContents")]
            ModifyContents = 5,
            
            /// <summary>
            /// Enum ModifyAnnotations for value: modifyAnnotations
            /// </summary>
            [EnumMember(Value = "modifyAnnotations")]
            ModifyAnnotations = 6,
            
            /// <summary>
            /// Enum FillIn for value: fillIn
            /// </summary>
            [EnumMember(Value = "fillIn")]
            FillIn = 7,
            
            /// <summary>
            /// Enum DocumentAssembly for value: documentAssembly
            /// </summary>
            [EnumMember(Value = "documentAssembly")]
            DocumentAssembly = 8,
            
            /// <summary>
            /// Enum Printing for value: printing
            /// </summary>
            [EnumMember(Value = "printing")]
            Printing = 9,
            
            /// <summary>
            /// Enum HighResolutionPrinting for value: highResolutionPrinting
            /// </summary>
            [EnumMember(Value = "highResolutionPrinting")]
            HighResolutionPrinting = 10
        }


        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocGenSettingsResultPdfEncryption" /> class.
        /// </summary>
        /// <param name="Algorithm">The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits. (default to AlgorithmEnum._128).</param>
        /// <param name="OwnerPassword">The password for the encrypted document.</param>
        /// <param name="UserPassword">The password required for opening the encrypted document.</param>
        /// <param name="Permissions">Permissions.</param>
        public DocGenSettingsResultPdfEncryption(AlgorithmEnum? Algorithm = AlgorithmEnum._128, string OwnerPassword = default(string), string UserPassword = default(string), List<PermissionsEnum> Permissions = default(List<PermissionsEnum>))
        {
            // use default value if no "Algorithm" provided
            if (Algorithm == null)
            {
                this.Algorithm = AlgorithmEnum._128;
            }
            else
            {
                this.Algorithm = Algorithm;
            }
            this.OwnerPassword = OwnerPassword;
            this.UserPassword = UserPassword;
            this.Permissions = Permissions;
        }
        

        /// <summary>
        /// The password for the encrypted document
        /// </summary>
        /// <value>The password for the encrypted document</value>
        [DataMember(Name="ownerPassword", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// The password required for opening the encrypted document
        /// </summary>
        /// <value>The password required for opening the encrypted document</value>
        [DataMember(Name="userPassword", EmitDefaultValue=false)]
        public string UserPassword { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocGenSettingsResultPdfEncryption {\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as DocGenSettingsResultPdfEncryption);
        }

        /// <summary>
        /// Returns true if DocGenSettingsResultPdfEncryption instances are equal
        /// </summary>
        /// <param name="input">Instance of DocGenSettingsResultPdfEncryption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocGenSettingsResultPdfEncryption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.OwnerPassword == input.OwnerPassword ||
                    (this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(input.OwnerPassword))
                ) && 
                (
                    this.UserPassword == input.UserPassword ||
                    (this.UserPassword != null &&
                    this.UserPassword.Equals(input.UserPassword))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.OwnerPassword != null)
                    hashCode = hashCode * 59 + this.OwnerPassword.GetHashCode();
                if (this.UserPassword != null)
                    hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
