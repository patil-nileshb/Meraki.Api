﻿namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsBonjourForwarding
{
	/// <summary>
	/// List the Bonjour forwarding setting and rules for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
	Task<SsidBonjourForwarding> GetNetworkWirelessSsidBonjourForwardingAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the bonjour forwarding setting and rules for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidBonjourForwarding"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/bonjourForwarding")]
	Task<SsidBonjourForwarding> UpdateNetworkWirelessSsidBonjourForwardingAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body] SsidBonjourForwarding updateNetworkWirelessSsidBonjourForwarding,
		CancellationToken cancellationToken = default
		);
}
