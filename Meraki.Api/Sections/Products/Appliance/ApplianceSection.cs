﻿namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceSection
{
	public IAppliancePerformance Performance { get; internal set; } = null!;
	public ApplianceSecuritySection Security { get; internal set; } = new();
	public ApplianceVpnSection Vpn { get; internal set; } = new();
}
