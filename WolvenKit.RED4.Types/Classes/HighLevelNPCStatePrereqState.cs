
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighLevelNPCStatePrereqState : NPCStatePrereqState
	{
		public HighLevelNPCStatePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
