
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipCraftedModule : ItemTooltipModuleController
	{
		public ItemTooltipCraftedModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
