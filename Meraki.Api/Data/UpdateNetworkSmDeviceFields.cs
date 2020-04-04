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
	/// UpdateNetworkSmDeviceFields
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSmDeviceFields :  IEquatable<UpdateNetworkSmDeviceFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSmDeviceFields" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateNetworkSmDeviceFields() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSmDeviceFields" /> class.
        /// </summary>
        /// <param name="WifiMac">The wifiMac of the device to be modified..</param>
        /// <param name="Id">The id of the device to be modified..</param>
        /// <param name="Serial">The serial of the device to be modified..</param>
        /// <param name="DeviceFields">DeviceFields (required).</param>
        public UpdateNetworkSmDeviceFields(string WifiMac = default, string Id = default, string Serial = default, DeviceFields DeviceFields = default)
        {
            // to ensure "DeviceFields" is required (not null)
            if (DeviceFields == null)
            {
                throw new InvalidDataException("DeviceFields is a required property for UpdateNetworkSmDeviceFields and cannot be null");
            }
            else
            {
                this.DeviceFields = DeviceFields;
            }
            this.WifiMac = WifiMac;
            this.Id = Id;
            this.Serial = Serial;
        }

        /// <summary>
        /// The wifiMac of the device to be modified.
        /// </summary>
        /// <value>The wifiMac of the device to be modified.</value>
        [DataMember(Name="wifiMac", EmitDefaultValue=false)]
        public string WifiMac { get; set; }
        /// <summary>
        /// The id of the device to be modified.
        /// </summary>
        /// <value>The id of the device to be modified.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The serial of the device to be modified.
        /// </summary>
        /// <value>The serial of the device to be modified.</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }
        /// <summary>
        /// Gets or Sets DeviceFields
        /// </summary>
        [DataMember(Name="deviceFields", EmitDefaultValue=false)]
        public DeviceFields DeviceFields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSmDeviceFields {\n");
            sb.Append("  WifiMac: ").Append(WifiMac).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  DeviceFields: ").Append(DeviceFields).Append("\n");
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
            return Equals(obj as UpdateNetworkSmDeviceFields);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSmDeviceFields instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSmDeviceFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSmDeviceFields other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  WifiMac == other.WifiMac ||
						  WifiMac != null &&
						  WifiMac.Equals(other.WifiMac)
					 ) &&
					 (
						  Id == other.Id ||
						  Id != null &&
						  Id.Equals(other.Id)
					 ) &&
					 (
						  Serial == other.Serial ||
						  Serial != null &&
						  Serial.Equals(other.Serial)
					 ) &&
					 (
						  DeviceFields == other.DeviceFields ||
						  DeviceFields != null &&
						  DeviceFields.Equals(other.DeviceFields)
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
                if (WifiMac != null)
                    hash = hash * 59 + WifiMac.GetHashCode();
                if (Id != null)
                    hash = hash * 59 + Id.GetHashCode();
                if (Serial != null)
                    hash = hash * 59 + Serial.GetHashCode();
                if (DeviceFields != null)
                    hash = hash * 59 + DeviceFields.GetHashCode();
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