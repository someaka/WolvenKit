
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_ItemNotification : gameInventoryListenerData_Base
	{
		public gameInventoryListenerData_ItemNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
