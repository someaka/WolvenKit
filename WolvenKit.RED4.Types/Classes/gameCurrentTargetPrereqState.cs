
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCurrentTargetPrereqState : gamePrereqState
	{
		public gameCurrentTargetPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
