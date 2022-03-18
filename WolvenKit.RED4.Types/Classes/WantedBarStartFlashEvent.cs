
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WantedBarStartFlashEvent : redEvent
	{
		public WantedBarStartFlashEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
