
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetHudComponent : WidgetHudComponentInterface
	{
		public WidgetHudComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
