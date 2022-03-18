
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatPoolPrereqState : gamePrereqState
	{
		public gameStatPoolPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
