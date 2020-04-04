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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettings
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSwitchSettings :  IEquatable<UpdateNetworkSwitchSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSwitchSettings" /> class.
        /// </summary>
        /// <param name="Vlan">Management VLAN.</param>
        /// <param name="UseCombinedPower">The use Combined Power as the default behavior of secondary power supplies on supported devices..</param>
        /// <param name="PowerExceptions">Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;.</param>
        public UpdateNetworkSwitchSettings(int? Vlan = default, bool? UseCombinedPower = default, List<PowerException> PowerExceptions = default)
        {
            this.Vlan = Vlan;
            this.UseCombinedPower = UseCombinedPower;
            this.PowerExceptions = PowerExceptions;
        }

        /// <summary>
        /// Management VLAN
        /// </summary>
        /// <value>Management VLAN</value>
        [DataMember(Name="vlan", EmitDefaultValue=false)]
        public int? Vlan { get; set; }
        /// <summary>
        /// The use Combined Power as the default behavior of secondary power supplies on supported devices.
        /// </summary>
        /// <value>The use Combined Power as the default behavior of secondary power supplies on supported devices.</value>
        [DataMember(Name="useCombinedPower", EmitDefaultValue=false)]
        public bool? UseCombinedPower { get; set; }
        /// <summary>
        /// Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;
        /// </summary>
        /// <value>Exceptions on a per switch basis to \&quot;useCombinedPower\&quot;</value>
        [DataMember(Name="powerExceptions", EmitDefaultValue=false)]
        public List<PowerException> PowerExceptions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSwitchSettings {\n");
            sb.Append("  Vlan: ").Append(Vlan).Append("\n");
            sb.Append("  UseCombinedPower: ").Append(UseCombinedPower).Append("\n");
            sb.Append("  PowerExceptions: ").Append(PowerExceptions).Append("\n");
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
            return Equals(obj as UpdateNetworkSwitchSettings);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSwitchSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSwitchSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSwitchSettings other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Vlan == other.Vlan ||
						  Vlan != null &&
						  Vlan.Equals(other.Vlan)
					 ) &&
					 (
						  UseCombinedPower == other.UseCombinedPower ||
						  UseCombinedPower != null &&
						  UseCombinedPower.Equals(other.UseCombinedPower)
					 ) &&
					 (
						  PowerExceptions == other.PowerExceptions ||
						  PowerExceptions != null &&
						  PowerExceptions.SequenceEqual(other.PowerExceptions)
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
                if (Vlan != null)
                    hash = hash * 59 + Vlan.GetHashCode();
                if (UseCombinedPower != null)
                    hash = hash * 59 + UseCombinedPower.GetHashCode();
                if (PowerExceptions != null)
                    hash = hash * 59 + PowerExceptions.GetHashCode();
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