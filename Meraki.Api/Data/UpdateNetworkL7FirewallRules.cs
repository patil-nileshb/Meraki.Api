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
	/// UpdateNetworkL7FirewallRules
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkL7FirewallRules :  IEquatable<UpdateNetworkL7FirewallRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkL7FirewallRules" /> class.
        /// </summary>
        /// <param name="Rules">An ordered array of the MX L7 firewall rules.</param>
        public UpdateNetworkL7FirewallRules(List<Rule6> Rules = default)
        {
            this.Rules = Rules;
        }

        /// <summary>
        /// An ordered array of the MX L7 firewall rules
        /// </summary>
        /// <value>An ordered array of the MX L7 firewall rules</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<Rule6> Rules { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkL7FirewallRules {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return Equals(obj as UpdateNetworkL7FirewallRules);
        }

        /// <summary>
        /// Returns true if UpdateNetworkL7FirewallRules instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkL7FirewallRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkL7FirewallRules other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: Rules == other.Rules ||
						  Rules != null &&
						  Rules.SequenceEqual(other.Rules);
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
                if (Rules != null)
                    hash = hash * 59 + Rules.GetHashCode();
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