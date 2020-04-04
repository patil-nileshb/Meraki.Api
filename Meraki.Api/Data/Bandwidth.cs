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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The bandwidth settings for clients bound to your group policy.
	/// </summary>
	[DataContract]
    public partial class Bandwidth :  IEquatable<Bandwidth>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bandwidth" /> class.
        /// </summary>
        /// <param name="Settings">Settings.</param>
        /// <param name="BandwidthLimits">BandwidthLimits.</param>
        public Bandwidth(Settings Settings = default, BandwidthLimits1 BandwidthLimits = default)
        {
            this.Settings = Settings;
            this.BandwidthLimits = BandwidthLimits;
        }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Settings Settings { get; set; }
        /// <summary>
        /// Gets or Sets BandwidthLimits
        /// </summary>
        [DataMember(Name="bandwidthLimits", EmitDefaultValue=false)]
        public BandwidthLimits1 BandwidthLimits { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bandwidth {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  BandwidthLimits: ").Append(BandwidthLimits).Append("\n");
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
            return Equals(obj as Bandwidth);
        }

        /// <summary>
        /// Returns true if Bandwidth instances are equal
        /// </summary>
        /// <param name="other">Instance of Bandwidth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bandwidth other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Settings == other.Settings ||
						  Settings != null &&
						  Settings.Equals(other.Settings)
					 ) &&
					 (
						  BandwidthLimits == other.BandwidthLimits ||
						  BandwidthLimits != null &&
						  BandwidthLimits.Equals(other.BandwidthLimits)
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
                if (Settings != null)
                    hash = hash * 59 + Settings.GetHashCode();
                if (BandwidthLimits != null)
                    hash = hash * 59 + BandwidthLimits.GetHashCode();
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