﻿namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationMonitorAdaptivePolicy
{
	/// <summary>
	/// Returns adaptive policy aggregate statistics for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationAdaptivePolicyOverview")]
	[Get("/organizations/{organizationId}/adaptivePolicy/overview")]
	Task<OrganizationAdaptivePolicyOverview> GetOrganizationAdaptivePolicyOverviewAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);
}