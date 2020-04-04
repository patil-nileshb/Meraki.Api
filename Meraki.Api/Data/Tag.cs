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
	/// Tag
	/// </summary>
	[DataContract]
    public partial class Tag :  IEquatable<Tag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        [JsonConstructor]
        protected Tag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="_Tag">The name of the tag (required).</param>
        /// <param name="Access">The privilege of the dashboard administrator on the tag (required).</param>
        public Tag(string _Tag = default, string Access = default)
        {
            // to ensure "_Tag" is required (not null)
            if (_Tag == null)
            {
                throw new InvalidDataException("_Tag is a required property for Tag and cannot be null");
            }
            else
            {
                this._Tag = _Tag;
            }
            // to ensure "Access" is required (not null)
            if (Access == null)
            {
                throw new InvalidDataException("Access is a required property for Tag and cannot be null");
            }
            else
            {
                this.Access = Access;
            }
        }

        /// <summary>
        /// The name of the tag
        /// </summary>
        /// <value>The name of the tag</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string _Tag { get; set; }
        /// <summary>
        /// The privilege of the dashboard administrator on the tag
        /// </summary>
        /// <value>The privilege of the dashboard administrator on the tag</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public string Access { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tag {\n");
            sb.Append("  _Tag: ").Append(_Tag).Append("\n");
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
            return Equals(obj as Tag);
        }

        /// <summary>
        /// Returns true if Tag instances are equal
        /// </summary>
        /// <param name="other">Instance of Tag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  _Tag == other._Tag ||
						  _Tag != null &&
						  _Tag.Equals(other._Tag)
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
                if (_Tag != null)
                    hash = hash * 59 + _Tag.GetHashCode();
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