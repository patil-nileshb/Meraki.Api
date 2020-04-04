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
	/// Defines state
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum State
    {

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Expired for "expired"
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// Enum Expiring for "expiring"
        /// </summary>
        [EnumMember(Value = "expiring")]
        Expiring,

        /// <summary>
        /// Enum Unused for "unused"
        /// </summary>
        [EnumMember(Value = "unused")]
        Unused,

        /// <summary>
        /// Enum UnusedActive for "unusedActive"
        /// </summary>
        [EnumMember(Value = "unusedActive")]
        UnusedActive,

        /// <summary>
        /// Enum RecentlyQueued for "recentlyQueued"
        /// </summary>
        [EnumMember(Value = "recentlyQueued")]
        RecentlyQueued
    }
}