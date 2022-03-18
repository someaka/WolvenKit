
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryPrereqState : gamePrereqState
	{
		public gameInventoryPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
