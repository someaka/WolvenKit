
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_PartAdded : gameInventoryListenerData_Base
	{
		public gameInventoryListenerData_PartAdded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
