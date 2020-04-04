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
	/// The type for the DHCP option. One of: 'text', 'ip', 'hex' or 'integer'
	/// </summary>
	/// <value>The type for the DHCP option. One of: 'text', 'ip', 'hex' or 'integer'</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum Type10
    {

        /// <summary>
        /// Enum Text for "text"
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Enum Ip for "ip"
        /// </summary>
        [EnumMember(Value = "ip")]
        Ip,

        /// <summary>
        /// Enum Hex for "hex"
        /// </summary>
        [EnumMember(Value = "hex")]
        Hex,

        /// <summary>
        /// Enum Integer for "integer"
        /// </summary>
        [EnumMember(Value = "integer")]
        Integer
    }
}