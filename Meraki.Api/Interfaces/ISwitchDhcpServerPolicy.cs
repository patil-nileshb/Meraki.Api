using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchDhcpServerPolicy
{
	/// <summary>
	/// Return the DHCP server policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchDhcpServerPolicy")]
	[Get("/networks/{networkId}/switch/dhcpServerPolicy")]
	Task<DhcpServerPolicy> GetDhcpServerPolicyAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the DHCP server policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchSettingsDhcpServerPolicy"></param>
	[ApiOperationId("updateNetworkSwitchDhcpServerPolicy")]
	[Put("/networks/{networkId}/switch/dhcpServerPolicy")]
	Task<DhcpServerPolicy> UpdateDhcpServerPolicyAsync(
		[AliasAs("networkId")] string networkId,
		[Body] DhcpServerPolicy updateNetworkSwitchSettingsDhcpServerPolicy,
		CancellationToken cancellationToken = default
		);
}
