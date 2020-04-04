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
	/// Rule14
	/// </summary>
	[DataContract]
    public partial class Rule14 :  IEquatable<Rule14>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule14" /> class.
        /// </summary>
        [JsonConstructor]
        protected Rule14() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule14" /> class.
        /// </summary>
        /// <param name="Comment">Description of the rule (optional).</param>
        /// <param name="Policy">Policy (required).</param>
        /// <param name="Protocol">Protocol (required).</param>
        /// <param name="SrcPort">Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;.</param>
        /// <param name="SrcCidr">Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (FQDN not supported) (required).</param>
        /// <param name="DestPort">Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;.</param>
        /// <param name="DestCidr">Comma-separated list of destination IP address(es) (in IP or CIDR notation) or &#39;any&#39; (FQDN not supported) (required).</param>
        /// <param name="SyslogEnabled">Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional).</param>
        public Rule14(string Comment = default, Policy Policy = default, Protocol Protocol = default, string SrcPort = default, string SrcCidr = default, string DestPort = default, string DestCidr = default, bool? SyslogEnabled = default)
        {
            // to ensure "Policy" is required (not null)
            if (Policy == null)
            {
                throw new InvalidDataException("Policy is a required property for Rule14 and cannot be null");
            }
            else
            {
                this.Policy = Policy;
            }
            // to ensure "Protocol" is required (not null)
            if (Protocol == null)
            {
                throw new InvalidDataException("Protocol is a required property for Rule14 and cannot be null");
            }
            else
            {
                this.Protocol = Protocol;
            }
            // to ensure "SrcCidr" is required (not null)
            if (SrcCidr == null)
            {
                throw new InvalidDataException("SrcCidr is a required property for Rule14 and cannot be null");
            }
            else
            {
                this.SrcCidr = SrcCidr;
            }
            // to ensure "DestCidr" is required (not null)
            if (DestCidr == null)
            {
                throw new InvalidDataException("DestCidr is a required property for Rule14 and cannot be null");
            }
            else
            {
                this.DestCidr = DestCidr;
            }
            this.Comment = Comment;
            this.SrcPort = SrcPort;
            this.DestPort = DestPort;
            this.SyslogEnabled = SyslogEnabled;
        }

        /// <summary>
        /// Description of the rule (optional)
        /// </summary>
        /// <value>Description of the rule (optional)</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Policy Policy { get; set; }
        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public Protocol Protocol { get; set; }
        /// <summary>
        /// Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;
        /// </summary>
        /// <value>Comma-separated list of source port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
        [DataMember(Name="srcPort", EmitDefaultValue=false)]
        public string SrcPort { get; set; }
        /// <summary>
        /// Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (FQDN not supported)
        /// </summary>
        /// <value>Comma-separated list of source IP address(es) (in IP or CIDR notation), or &#39;any&#39; (FQDN not supported)</value>
        [DataMember(Name="srcCidr", EmitDefaultValue=false)]
        public string SrcCidr { get; set; }
        /// <summary>
        /// Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;
        /// </summary>
        /// <value>Comma-separated list of destination port(s) (integer in the range 1-65535), or &#39;any&#39;</value>
        [DataMember(Name="destPort", EmitDefaultValue=false)]
        public string DestPort { get; set; }
        /// <summary>
        /// Comma-separated list of destination IP address(es) (in IP or CIDR notation) or &#39;any&#39; (FQDN not supported)
        /// </summary>
        /// <value>Comma-separated list of destination IP address(es) (in IP or CIDR notation) or &#39;any&#39; (FQDN not supported)</value>
        [DataMember(Name="destCidr", EmitDefaultValue=false)]
        public string DestCidr { get; set; }
        /// <summary>
        /// Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)
        /// </summary>
        /// <value>Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)</value>
        [DataMember(Name="syslogEnabled", EmitDefaultValue=false)]
        public bool? SyslogEnabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule14 {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  SrcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  SrcCidr: ").Append(SrcCidr).Append("\n");
            sb.Append("  DestPort: ").Append(DestPort).Append("\n");
            sb.Append("  DestCidr: ").Append(DestCidr).Append("\n");
            sb.Append("  SyslogEnabled: ").Append(SyslogEnabled).Append("\n");
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
            return Equals(obj as Rule14);
        }

        /// <summary>
        /// Returns true if Rule14 instances are equal
        /// </summary>
        /// <param name="other">Instance of Rule14 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule14 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Comment == other.Comment ||
						  Comment != null &&
						  Comment.Equals(other.Comment)
					 ) &&
					 (
						  Policy == other.Policy ||
						  Policy != null &&
						  Policy.Equals(other.Policy)
					 ) &&
					 (
						  Protocol == other.Protocol ||
						  Protocol != null &&
						  Protocol.Equals(other.Protocol)
					 ) &&
					 (
						  SrcPort == other.SrcPort ||
						  SrcPort != null &&
						  SrcPort.Equals(other.SrcPort)
					 ) &&
					 (
						  SrcCidr == other.SrcCidr ||
						  SrcCidr != null &&
						  SrcCidr.Equals(other.SrcCidr)
					 ) &&
					 (
						  DestPort == other.DestPort ||
						  DestPort != null &&
						  DestPort.Equals(other.DestPort)
					 ) &&
					 (
						  DestCidr == other.DestCidr ||
						  DestCidr != null &&
						  DestCidr.Equals(other.DestCidr)
					 ) &&
					 (
						  SyslogEnabled == other.SyslogEnabled ||
						  SyslogEnabled != null &&
						  SyslogEnabled.Equals(other.SyslogEnabled)
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
                if (Comment != null)
                    hash = hash * 59 + Comment.GetHashCode();
                if (Policy != null)
                    hash = hash * 59 + Policy.GetHashCode();
                if (Protocol != null)
                    hash = hash * 59 + Protocol.GetHashCode();
                if (SrcPort != null)
                    hash = hash * 59 + SrcPort.GetHashCode();
                if (SrcCidr != null)
                    hash = hash * 59 + SrcCidr.GetHashCode();
                if (DestPort != null)
                    hash = hash * 59 + DestPort.GetHashCode();
                if (DestCidr != null)
                    hash = hash * 59 + DestCidr.GetHashCode();
                if (SyslogEnabled != null)
                    hash = hash * 59 + SyslogEnabled.GetHashCode();
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