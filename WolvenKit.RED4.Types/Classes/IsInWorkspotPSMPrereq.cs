
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsInWorkspotPSMPrereq : PlayerStateMachinePrereq
	{
		public IsInWorkspotPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
