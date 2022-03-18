
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNotPrereqState : gamePrereqState
	{
		public gameNotPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
