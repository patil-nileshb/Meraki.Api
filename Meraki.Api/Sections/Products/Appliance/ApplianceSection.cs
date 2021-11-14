﻿namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceSection
{
	public IApplianceConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; internal set; } = null!;
	public ApplianceContentFilteringSection ContentFiltering { get; internal set; } = new();
	public ApplianceDhcpSection Dhpc { get; internal set; } = new();
	public ApplianceFirewallSection Firewall { get; internal set; } = new();
	public IAppliancePerformance Performance { get; internal set; } = null!;
	public IAppliancePorts Ports { get; internal set; } = null!;
	public ApplianceSecuritySection Security { get; internal set; } = new();
	public IApplianceSettings Settings { get; internal set; } = null!;
	public IApplianceSingleLan SingleLan { get; internal set; } = null!;
	public IApplianceStaticRoutes StaticRoutes { get; internal set; } = null!;
	public ApplianceTrafficShapingSection TrafficShaping { get; internal set; } = new();
	public ApplianceVpnSection Vpn { get; internal set; } = new();
	public IApplianceWarmSpare WarmSpare { get; internal set; } = null!;
}
