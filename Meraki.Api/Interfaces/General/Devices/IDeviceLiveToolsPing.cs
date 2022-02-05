﻿namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceLiveToolsPing
{
	/// <summary>
	/// Enqueue a job to ping a target host from the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsPing">Body</param>
	[ApiOperationId("createDeviceLiveToolsPing")]
	[Post("/devices/{serial}/liveTools/ping")]
	Task<LiveToolPing> CreateDeviceLiveToolsPingAsync(
		[AliasAs("serial")] string serial,
		[Body] LiveToolPingCreate createDeviceLiveToolsPing,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="id">The device id</param>
	[ApiOperationId("getDeviceLiveToolsPing")]
	[Get("/devices/{serial}/liveTools/ping/{id}")]
	Task<LiveToolPing> GetDeviceLiveToolsPingAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("id")] string id,
		CancellationToken cancellationToken = default);
}
