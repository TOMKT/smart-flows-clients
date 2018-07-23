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
    /// Defines cleanupAction
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CleanupAction
    {
        
        /// <summary>
        /// Enum RemoveInternalSuccess for value: removeInternalSuccess
        /// </summary>
        [EnumMember(Value = "removeInternalSuccess")]
        RemoveInternalSuccess = 1,
        
        /// <summary>
        /// Enum RemoveOutputSuccess for value: removeOutputSuccess
        /// </summary>
        [EnumMember(Value = "removeOutputSuccess")]
        RemoveOutputSuccess = 2,
        
        /// <summary>
        /// Enum RemoveFullSuccess for value: removeFullSuccess
        /// </summary>
        [EnumMember(Value = "removeFullSuccess")]
        RemoveFullSuccess = 3,
        
        /// <summary>
        /// Enum RemoveInternalError for value: removeInternalError
        /// </summary>
        [EnumMember(Value = "removeInternalError")]
        RemoveInternalError = 4,
        
        /// <summary>
        /// Enum RemoveOutputError for value: removeOutputError
        /// </summary>
        [EnumMember(Value = "removeOutputError")]
        RemoveOutputError = 5,
        
        /// <summary>
        /// Enum RemoveFullError for value: removeFullError
        /// </summary>
        [EnumMember(Value = "removeFullError")]
        RemoveFullError = 6,
        
        /// <summary>
        /// Enum RemoveInternalCancelled for value: removeInternalCancelled
        /// </summary>
        [EnumMember(Value = "removeInternalCancelled")]
        RemoveInternalCancelled = 7,
        
        /// <summary>
        /// Enum RemoveOutputCancelled for value: removeOutputCancelled
        /// </summary>
        [EnumMember(Value = "removeOutputCancelled")]
        RemoveOutputCancelled = 8,
        
        /// <summary>
        /// Enum RemoveFullCancelled for value: removeFullCancelled
        /// </summary>
        [EnumMember(Value = "removeFullCancelled")]
        RemoveFullCancelled = 9,
        
        /// <summary>
        /// Enum RemoveInternalInterrupted for value: removeInternalInterrupted
        /// </summary>
        [EnumMember(Value = "removeInternalInterrupted")]
        RemoveInternalInterrupted = 10,
        
        /// <summary>
        /// Enum RemoveOutputInterrupted for value: removeOutputInterrupted
        /// </summary>
        [EnumMember(Value = "removeOutputInterrupted")]
        RemoveOutputInterrupted = 11,
        
        /// <summary>
        /// Enum RemoveFullInterrupted for value: removeFullInterrupted
        /// </summary>
        [EnumMember(Value = "removeFullInterrupted")]
        RemoveFullInterrupted = 12,
        
        /// <summary>
        /// Enum RemoveSelectFlow for value: removeSelectFlow
        /// </summary>
        [EnumMember(Value = "removeSelectFlow")]
        RemoveSelectFlow = 13,
        
        /// <summary>
        /// Enum InterruptWaiting for value: interruptWaiting
        /// </summary>
        [EnumMember(Value = "interruptWaiting")]
        InterruptWaiting = 14,
        
        /// <summary>
        /// Enum InterruptUserInput for value: interruptUserInput
        /// </summary>
        [EnumMember(Value = "interruptUserInput")]
        InterruptUserInput = 15
    }

}