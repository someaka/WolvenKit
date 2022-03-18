
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FallPSMPrereq : PlayerStateMachinePrereq
	{
		public FallPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
