/* 
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)     
 *
 * OpenAPI spec version: 0.10.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkClientSplashAuthorizationStatus
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkClientSplashAuthorizationStatus :  IEquatable<UpdateNetworkClientSplashAuthorizationStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkClientSplashAuthorizationStatus" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateNetworkClientSplashAuthorizationStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkClientSplashAuthorizationStatus" /> class.
        /// </summary>
        /// <param name="Ssids">The target SSIDs. Each SSID must be enabled and must have Click-through splash enabled. For each SSID where isAuthorized is true, the expiration time will automatically be set according to the SSID&#39;s splash frequency. Not all networks support configuring all SSIDs (required).</param>
        public UpdateNetworkClientSplashAuthorizationStatus(Dictionary<string, GeneratedObject10> Ssids = default)
        {
            // to ensure "Ssids" is required (not null)
            if (Ssids == null)
            {
                throw new InvalidDataException("Ssids is a required property for UpdateNetworkClientSplashAuthorizationStatus and cannot be null");
            }
            else
            {
                this.Ssids = Ssids;
            }
        }

        /// <summary>
        /// The target SSIDs. Each SSID must be enabled and must have Click-through splash enabled. For each SSID where isAuthorized is true, the expiration time will automatically be set according to the SSID&#39;s splash frequency. Not all networks support configuring all SSIDs
        /// </summary>
        /// <value>The target SSIDs. Each SSID must be enabled and must have Click-through splash enabled. For each SSID where isAuthorized is true, the expiration time will automatically be set according to the SSID&#39;s splash frequency. Not all networks support configuring all SSIDs</value>
        [DataMember(Name="ssids", EmitDefaultValue=false)]
        public Dictionary<string, GeneratedObject10> Ssids { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkClientSplashAuthorizationStatus {\n");
            sb.Append("  Ssids: ").Append(Ssids).Append("\n");
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
            return Equals(obj as UpdateNetworkClientSplashAuthorizationStatus);
        }

        /// <summary>
        /// Returns true if UpdateNetworkClientSplashAuthorizationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkClientSplashAuthorizationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkClientSplashAuthorizationStatus other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: Ssids == other.Ssids ||
						  Ssids != null &&
						  Ssids.SequenceEqual(other.Ssids);
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
                if (Ssids != null)
                    hash = hash * 59 + Ssids.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}