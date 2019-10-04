﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A network
	/// </summary>
	[DataContract]
	public class Network : NamedIdentifiedItem
	{
#pragma warning disable IDE1006 // Naming Styles
		public const int MaxNameLength = 38;
#pragma warning restore IDE1006 // Naming Styles

		/// <summary>
		/// OrganizationId
		/// </summary>
		[DataMember(Name = "organizationId")]
		public string OrganizationId { get; set; } = null!;

		/// <summary>
		/// timeZone
		/// </summary>
		[DataMember(Name = "timeZone")]
		public string TimeZone { get; set; } = null!;

		/// <summary>
		/// tags
		/// </summary>
		[DataMember(Name = "tags")]
		public string Tags { get; set; } = null!;

		/// <summary>
		/// type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = null!;

		/// <summary>
		/// disableMyMerakiCom
		/// </summary>
		[DataMember(Name = "disableMyMerakiCom")]
		public bool DisableMyMerakiCom { get; set; }

		/// <summary>
		/// Product types
		/// </summary>
		[DataMember(Name = "productTypes")]
		public List<string> ProductTypes { get; set; } = new List<string>();
	}
}