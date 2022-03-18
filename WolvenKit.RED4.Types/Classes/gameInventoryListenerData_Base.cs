
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryListenerData_Base : RedBaseClass
	{
		public gameInventoryListenerData_Base()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
