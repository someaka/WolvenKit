
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardPrereqState : gamePrereqState
	{
		public gameBlackboardPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
