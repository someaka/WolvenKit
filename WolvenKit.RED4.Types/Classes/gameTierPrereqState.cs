
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTierPrereqState : gamePrereqState
	{
		public gameTierPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
