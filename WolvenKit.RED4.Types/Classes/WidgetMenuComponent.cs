
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetMenuComponent : WidgetMenuComponentInterface
	{
		public WidgetMenuComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
