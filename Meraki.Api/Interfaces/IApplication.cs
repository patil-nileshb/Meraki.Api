using Meraki.Api.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IApplication
	{
		/// <summary>
		/// getNetworkInsightApplicationHealthByTime
		/// </summary>
		/// <remarks>
		/// Get application health by time
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="applicationId"></param>
		/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 7 days from today.</param>
		/// <param name="t1">The end of the timespan for the data. t1 can be a maximum of 7 days after t0.</param>
		/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameters t0 and t1. The value must be in seconds and be less than or equal to 7 days. The default is 2 hours.</param>
		/// <param name="resolution">The time resolution in seconds for returned data. The valid resolutions are: 60, 300, 3600, 86400. The default is 300.</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/insight/applications/{applicationId}/healthByTime")]
		Task<List<HealthByTime>> GetNetworkInsightApplicationHealthByTime(
			[AliasAs("networkId")] string networkId,
			[AliasAs("applicationId")] string applicationId,
			[AliasAs("t0")] string t0 = null!,
			[AliasAs("t1")] string t1 = null!,
			[AliasAs("timespan")] double? timespan = null,
			[AliasAs("resolution")] int? resolution = null
			);

		/// <summary>
		/// getOrganizationInsightApplications
		/// </summary>
		/// <remarks>
		/// List all Insight tracked applications
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/insight/applications")]
		Task<List<InsightApplication>> GetOrganizationInsightApplications(
			[AliasAs("organizationId")] string organizationId
			);
	}
}