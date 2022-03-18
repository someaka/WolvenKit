
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingPSMPrereq : PlayerStateMachinePrereq
	{
		public SwimmingPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
