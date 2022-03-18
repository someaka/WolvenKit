
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelPSMPrereq : PlayerStateMachinePrereq
	{
		public HighLevelPSMPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
