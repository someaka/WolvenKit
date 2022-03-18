
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_InventoryEmpty : gameInventoryListenerData_Base
	{
		public gameInventoryListenerData_InventoryEmpty()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
