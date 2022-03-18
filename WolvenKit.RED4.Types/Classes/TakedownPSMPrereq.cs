
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TakedownPSMPrereq : PlayerStateMachinePrereq
	{
		public TakedownPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
