
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceLockElevator : ToggleLock
	{
		public ForceLockElevator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
