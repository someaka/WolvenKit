
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatCheckPrereqState : gamePrereqState
	{
		public StatCheckPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
