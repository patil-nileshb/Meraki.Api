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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Subnet
	/// </summary>
	[DataContract]
    public partial class Subnet :  IEquatable<Subnet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subnet" /> class.
        /// </summary>
        [JsonConstructor]
        protected Subnet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subnet" /> class.
        /// </summary>
        /// <param name="LocalSubnet">The CIDR notation subnet used within the VPN (required).</param>
        /// <param name="UseVpn">Indicates the presence of the subnet in the VPN.</param>
        public Subnet(string LocalSubnet = default, bool? UseVpn = default)
        {
            // to ensure "LocalSubnet" is required (not null)
            if (LocalSubnet == null)
            {
                throw new InvalidDataException("LocalSubnet is a required property for Subnet and cannot be null");
            }
            else
            {
                this.LocalSubnet = LocalSubnet;
            }
            this.UseVpn = UseVpn;
        }

        /// <summary>
        /// The CIDR notation subnet used within the VPN
        /// </summary>
        /// <value>The CIDR notation subnet used within the VPN</value>
        [DataMember(Name="localSubnet", EmitDefaultValue=false)]
        public string LocalSubnet { get; set; }
        /// <summary>
        /// Indicates the presence of the subnet in the VPN
        /// </summary>
        /// <value>Indicates the presence of the subnet in the VPN</value>
        [DataMember(Name="useVpn", EmitDefaultValue=false)]
        public bool? UseVpn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subnet {\n");
            sb.Append("  LocalSubnet: ").Append(LocalSubnet).Append("\n");
            sb.Append("  UseVpn: ").Append(UseVpn).Append("\n");
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
            return Equals(obj as Subnet);
        }

        /// <summary>
        /// Returns true if Subnet instances are equal
        /// </summary>
        /// <param name="other">Instance of Subnet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subnet other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  LocalSubnet == other.LocalSubnet ||
						  LocalSubnet != null &&
						  LocalSubnet.Equals(other.LocalSubnet)
					 ) &&
					 (
						  UseVpn == other.UseVpn ||
						  UseVpn != null &&
						  UseVpn.Equals(other.UseVpn)
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
                if (LocalSubnet != null)
                    hash = hash * 59 + LocalSubnet.GetHashCode();
                if (UseVpn != null)
                    hash = hash * 59 + UseVpn.GetHashCode();
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