﻿using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface IFirewalls
	{
		/// <summary>
		/// Return the cellular firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
		Task<CellularFirewallRules> GetCellularFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the cellular firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="mxCellularFirewallRules">Body for updating network cellular firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
		Task<CellularFirewallRules> UpdateCellularFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] CellularFirewallRules mxCellularFirewallRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the appliance services and their accessibility rules
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices")]
		Task<List<FirewalledService>> GetFirewalledServicesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the accessibility settings of the given service
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="serviceType">The serviceType</param>
		[Get("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
		Task<List<FirewalledService>> GetFirewalledServiceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("service")] FirewalledServiceType serviceType,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Updates the accessibility settings for the given service
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="serviceType">The serviceType</param>
		[Put("/networks/{networkId}/appliance/firewall/firewalledServices/{service}")]
		Task<List<FirewalledService>> UpdateFirewalledServiceAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("service")] FirewalledServiceType serviceType,
			[Body] FirewalledService firewalledService,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the inbound firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<InboundFirewallRules> GetInboundFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the inbound firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="inboundFirewallRules">Body for updating inbound firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<InboundFirewallRules> UpdateInboundFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] InboundFirewallRules inboundFirewallRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the L3 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
		Task<Layer3FirewallRules> GetL3FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the L3 firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkL3FirewallRules">Body for updating L3 firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
		Task<Layer3FirewallRules> UpdateL3FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Layer3FirewallRules updateNetworkL3FirewallRules,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the MX L7 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceFirewallL7FirewallRules")]
		[Get("/networks/{networkId}/appliance/firewall/l7FirewallRules")]
		Task<Layer7FirewallRules> GetL7FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the MX L7 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="layer7FirewallRules">Body for updating firewall rules</param>
		[ApiOperationId("updateNetworkApplianceFirewallL7FirewallRules")]
		[Put("/networks/{networkId}/appliance/firewall/l7FirewallRules")]
		Task<Layer7FirewallRules> UpdateL7FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Layer7FirewallRules layer7FirewallRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the L7 firewall application categories and their associated applications for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceFirewallL7FirewallRulesApplicationCategories")]
		[Get("/networks/{networkId}/appliance/firewall/l7FirewallRules/applicationCategories")]
		Task<Layer7ApplicationCategories> GetL7FirewallRulesApplicationCategoriesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the 1:Many NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceFirewallOneToManyNatRules")]
		[Get("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<OneToManyNatRules> GetOneToManyNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the 1:Many NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="oneToManyNatRules">Body for updating mapping rules</param>
		[ApiOperationId("updateNetworkApplianceFirewallOneToManyNatRules")]
		[Put("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<OneToManyNatRules> UpdateOneToManyNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] OneToManyNatRules oneToManyNatRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the 1:1 NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("updateNetworkApplianceFirewallOneToManyNatRules")]
		[Get("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<OneToOneNatRules> GetOneToOneNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the 1:1 NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="oneToOneNatRules">Body for updating mapping rules</param>
		[ApiOperationId("updateNetworkApplianceFirewallOneToOneNatRules")]
		[Put("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<OneToOneNatRules> UpdateOneToOneNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] OneToOneNatRules oneToOneNatRules,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the port forwarding rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkApplianceFirewallPortForwardingRules")]
		[Get("/networks/{networkId}/appliance/firewall/portForwardingRules")]
		Task<PortForwardingRules> GetPortForwardingRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the port forwarding rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkPortForwardingRules">Body for updating port forwarding rules</param>
		[ApiOperationId("updateNetworkApplianceFirewallPortForwardingRules")]
		[Put("/networks/{networkId}/appliance/firewall/portForwardingRules")]
		Task<PortForwardingRules> UpdatePortForwardingRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] PortForwardingRules updateNetworkPortForwardingRules,
			CancellationToken cancellationToken = default
			);
	}
}