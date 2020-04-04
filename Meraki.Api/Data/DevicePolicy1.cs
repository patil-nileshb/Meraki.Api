/* 
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)     
 *
 * OpenAPI spec version: 0.10.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked' or 'Normal'. Required.
	/// </summary>
	/// <value>The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked' or 'Normal'. Required.</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum DevicePolicy1
    {

        /// <summary>
        /// Enum Whitelisted for "Whitelisted"
        /// </summary>
        [EnumMember(Value = "Whitelisted")]
        Whitelisted,

        /// <summary>
        /// Enum Blocked for "Blocked"
        /// </summary>
        [EnumMember(Value = "Blocked")]
        Blocked,

        /// <summary>
        /// Enum Normal for "Normal"
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal
    }
}