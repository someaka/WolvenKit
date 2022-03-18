
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePSMPrereq : PlayerStateMachinePrereq
	{
		public MeleePSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
