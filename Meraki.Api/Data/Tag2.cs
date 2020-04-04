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
	/// Tag2
	/// </summary>
	[DataContract]
    public partial class Tag2 :  IEquatable<Tag2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag2" /> class.
        /// </summary>
        /// <param name="Tag">The name of the tag.</param>
        /// <param name="Access">The privilege of the SAML administrator on the tag.</param>
        public Tag2(string Tag = default, string Access = default)
        {
            this.Tag = Tag;
            this.Access = Access;
        }

        /// <summary>
        /// The name of the tag
        /// </summary>
        /// <value>The name of the tag</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }
        /// <summary>
        /// The privilege of the SAML administrator on the tag
        /// </summary>
        /// <value>The privilege of the SAML administrator on the tag</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public string Access { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tag2 {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
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
            return Equals(obj as Tag2);
        }

        /// <summary>
        /// Returns true if Tag2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Tag2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag2 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Tag == other.Tag ||
						  Tag != null &&
						  Tag.Equals(other.Tag)
					 ) &&
					 (
						  Access == other.Access ||
						  Access != null &&
						  Access.Equals(other.Access)
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
                if (Tag != null)
                    hash = hash * 59 + Tag.GetHashCode();
                if (Access != null)
                    hash = hash * 59 + Access.GetHashCode();
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