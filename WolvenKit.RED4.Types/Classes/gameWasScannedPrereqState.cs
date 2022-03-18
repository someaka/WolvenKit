
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWasScannedPrereqState : gamePrereqState
	{
		public gameWasScannedPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
