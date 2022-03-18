
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionPSMPrereq : PlayerStateMachinePrereq
	{
		public LocomotionPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
