
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BodyDisposalPSMPrereq : PlayerStateMachinePrereq
	{
		public BodyDisposalPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
