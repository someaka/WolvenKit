
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerReachablePrereqState : gamePrereqState
	{
		public IsPlayerReachablePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
