
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnOffPrereqState : gamePrereqState
	{
		public OnOffPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
