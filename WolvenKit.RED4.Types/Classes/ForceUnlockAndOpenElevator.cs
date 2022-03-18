
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceUnlockAndOpenElevator : ToggleLock
	{
		public ForceUnlockAndOpenElevator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
