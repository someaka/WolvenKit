
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZonesPSMPrereqState : PlayerStateMachinePrereqState
	{
		public ZonesPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
