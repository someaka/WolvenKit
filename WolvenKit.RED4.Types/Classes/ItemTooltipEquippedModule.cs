
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipEquippedModule : ItemTooltipModuleController
	{
		public ItemTooltipEquippedModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
