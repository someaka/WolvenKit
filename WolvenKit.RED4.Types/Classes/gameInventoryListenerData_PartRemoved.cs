
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_PartRemoved : gameInventoryListenerData_Base
	{
		public gameInventoryListenerData_PartRemoved()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
