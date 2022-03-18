
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCIsAggressiveState : gamePrereqState
	{
		public NPCIsAggressiveState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
