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
	/// UpdateNetworkSyslogServers
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSyslogServers :  IEquatable<UpdateNetworkSyslogServers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSyslogServers" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateNetworkSyslogServers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSyslogServers" /> class.
        /// </summary>
        /// <param name="Servers">A list of the syslog servers for this network (required).</param>
        public UpdateNetworkSyslogServers(List<Server> Servers = default)
        {
            // to ensure "Servers" is required (not null)
            if (Servers == null)
            {
                throw new InvalidDataException("Servers is a required property for UpdateNetworkSyslogServers and cannot be null");
            }
            else
            {
                this.Servers = Servers;
            }
        }

        /// <summary>
        /// A list of the syslog servers for this network
        /// </summary>
        /// <value>A list of the syslog servers for this network</value>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public List<Server> Servers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSyslogServers {\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
            return Equals(obj as UpdateNetworkSyslogServers);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSyslogServers instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSyslogServers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSyslogServers other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: Servers == other.Servers ||
						  Servers != null &&
						  Servers.SequenceEqual(other.Servers);
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
                if (Servers != null)
                    hash = hash * 59 + Servers.GetHashCode();
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