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
	/// CombineOrganizationNetworks
	/// </summary>
	[DataContract]
    public partial class CombineOrganizationNetworks :  IEquatable<CombineOrganizationNetworks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombineOrganizationNetworks" /> class.
        /// </summary>
        [JsonConstructor]
        protected CombineOrganizationNetworks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombineOrganizationNetworks" /> class.
        /// </summary>
        /// <param name="Name">The name of the combined network (required).</param>
        /// <param name="NetworkIds">A list of the network IDs that will be combined. If an ID of a combined network is included in this list, the other networks in the list will be grouped into that network (required).</param>
        /// <param name="EnrollmentString">A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break. All networks that are part of this combined network will have their enrollment string appended by &#39;-network_type&#39;. If left empty, all exisitng enrollment strings will be deleted..</param>
        public CombineOrganizationNetworks(string Name = default, List<string> NetworkIds = default, string EnrollmentString = default)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CombineOrganizationNetworks and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "NetworkIds" is required (not null)
            if (NetworkIds == null)
            {
                throw new InvalidDataException("NetworkIds is a required property for CombineOrganizationNetworks and cannot be null");
            }
            else
            {
                this.NetworkIds = NetworkIds;
            }
            this.EnrollmentString = EnrollmentString;
        }

        /// <summary>
        /// The name of the combined network
        /// </summary>
        /// <value>The name of the combined network</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// A list of the network IDs that will be combined. If an ID of a combined network is included in this list, the other networks in the list will be grouped into that network
        /// </summary>
        /// <value>A list of the network IDs that will be combined. If an ID of a combined network is included in this list, the other networks in the list will be grouped into that network</value>
        [DataMember(Name="networkIds", EmitDefaultValue=false)]
        public List<string> NetworkIds { get; set; }
        /// <summary>
        /// A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break. All networks that are part of this combined network will have their enrollment string appended by &#39;-network_type&#39;. If left empty, all exisitng enrollment strings will be deleted.
        /// </summary>
        /// <value>A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break. All networks that are part of this combined network will have their enrollment string appended by &#39;-network_type&#39;. If left empty, all exisitng enrollment strings will be deleted.</value>
        [DataMember(Name="enrollmentString", EmitDefaultValue=false)]
        public string EnrollmentString { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombineOrganizationNetworks {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkIds: ").Append(NetworkIds).Append("\n");
            sb.Append("  EnrollmentString: ").Append(EnrollmentString).Append("\n");
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
            return Equals(obj as CombineOrganizationNetworks);
        }

        /// <summary>
        /// Returns true if CombineOrganizationNetworks instances are equal
        /// </summary>
        /// <param name="other">Instance of CombineOrganizationNetworks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombineOrganizationNetworks other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Name == other.Name ||
						  Name != null &&
						  Name.Equals(other.Name)
					 ) &&
					 (
						  NetworkIds == other.NetworkIds ||
						  NetworkIds != null &&
						  NetworkIds.SequenceEqual(other.NetworkIds)
					 ) &&
					 (
						  EnrollmentString == other.EnrollmentString ||
						  EnrollmentString != null &&
						  EnrollmentString.Equals(other.EnrollmentString)
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
                if (Name != null)
                    hash = hash * 59 + Name.GetHashCode();
                if (NetworkIds != null)
                    hash = hash * 59 + NetworkIds.GetHashCode();
                if (EnrollmentString != null)
                    hash = hash * 59 + EnrollmentString.GetHashCode();
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