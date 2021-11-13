﻿namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceLossAndLatencyHistory
{
	/// <summary>
	/// Get the uplink loss percentage and latency in milliseconds, and goodput in kilobits per second for a wired network device.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="ip">The destination IP used to obtain the requested stats. This is required.</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 365 days from today. (optional)</param>
	/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 31 days after t0. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60, 600, 3600, 86400. The default is 60. (optional)</param>
	/// <param name="uplink">The WAN uplink used to obtain the requested stats. Valid uplinks are wan1, wan2, cellular. The default is wan1. (optional)</param>
	[Get("/devices/{serial}/lossAndLatencyHistory")]
	Task<List<LossAndLatencyHistory>> GetLossAndLatencyHistoryAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("ip")] string ip,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("t1")] string t1 = null!,
		[AliasAs("timespan")] double? timespan = null,
		[AliasAs("resolution")] int? resolution = null,
		[AliasAs("uplink")] string uplink = null!,
		CancellationToken cancellationToken = default);
}
