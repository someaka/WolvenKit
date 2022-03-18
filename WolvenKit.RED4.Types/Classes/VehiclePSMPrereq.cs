
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePSMPrereq : PlayerStateMachinePrereq
	{
		public VehiclePSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
