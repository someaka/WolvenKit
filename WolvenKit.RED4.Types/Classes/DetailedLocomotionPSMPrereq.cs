
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DetailedLocomotionPSMPrereq : PlayerStateMachinePrereq
	{
		public DetailedLocomotionPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
