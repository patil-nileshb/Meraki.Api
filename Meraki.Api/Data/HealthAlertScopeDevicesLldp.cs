namespace Meraki.Api.Data;

/// <summary>
/// Health alert scope
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class HealthAlertScopeDevicesLldp
{
	/// <summary>
	/// Port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;
}
