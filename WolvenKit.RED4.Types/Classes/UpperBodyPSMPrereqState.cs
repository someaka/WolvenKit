
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpperBodyPSMPrereqState : PlayerStateMachinePrereqState
	{
		public UpperBodyPSMPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
