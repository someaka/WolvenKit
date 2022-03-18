
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerPrereqState : gamePrereqState
	{
		public IsPlayerPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
