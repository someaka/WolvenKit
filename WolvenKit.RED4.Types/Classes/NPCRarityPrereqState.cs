
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCRarityPrereqState : gamePrereqState
	{
		public NPCRarityPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
