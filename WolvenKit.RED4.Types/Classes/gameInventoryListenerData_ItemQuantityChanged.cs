
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_ItemQuantityChanged : gameInventoryListenerData_Base
	{
		public gameInventoryListenerData_ItemQuantityChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
