
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviortweakItemsInInventoryListener : gameIInventoryListener
	{
		public AIbehaviortweakItemsInInventoryListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
