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
	/// Enable or disable the interface (only for MX devices). Valid values are 'enabled', 'disabled', and 'not configured'.
	/// </summary>
	/// <value>Enable or disable the interface (only for MX devices). Valid values are 'enabled', 'disabled', and 'not configured'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum WanEnabled
    {

        /// <summary>
        /// Enum Enabled for "enabled"
        /// </summary>
        [EnumMember(Value = "enabled")]
        Enabled,

        /// <summary>
        /// Enum Disabled for "disabled"
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,

        /// <summary>
        /// Enum Notconfigured for "not configured"
        /// </summary>
        [EnumMember(Value = "not configured")]
        Notconfigured
    }
}