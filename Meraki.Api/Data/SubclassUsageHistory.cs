﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Usage history
	/// </summary>
	[DataContract]
	public partial class SubclassUsageHistory
	{
		/// <summary>
		/// Ts
		/// </summary>
		[DataMember(Name = "ts")]
		public string Ts { get; set; } = string.Empty;

		/// <summary>
		/// Recv
		/// </summary>
		[DataMember(Name = "recv")]
		public int Recv { get; set; }

		/// <summary>
		/// Sent
		/// </summary>
		[DataMember(Name = "sent")]
		public int Sent { get; set; }
	}
}