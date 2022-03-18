
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BodyCarryingPSMPrereq : PlayerStateMachinePrereq
	{
		public BodyCarryingPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
