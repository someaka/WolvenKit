
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WidgetBaseComponent : entIPlacedComponent
	{
		public WidgetBaseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
