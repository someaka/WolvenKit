
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRenderOverlayEvent : redEvent
	{
		public entRenderOverlayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
