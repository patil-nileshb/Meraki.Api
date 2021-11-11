namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchSettings
{
	/// <summary>
	/// Returns the switch network settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchSettings")]
	[Get("/networks/{networkId}/switch/settings")]
	Task<SwitchSettings> GetNetworkSwitchSettingsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update switch network settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchSettings"></param>
	[ApiOperationId("updateNetworkSwitchSettings")]
	[Put("/networks/{networkId}/switch/settings")]
	Task<SwitchSettings> UpdateNetworkSwitchSettingsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] SwitchSettings updateNetworkSwitchSettings,
		CancellationToken cancellationToken = default
		);
}
