
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WantedBarEndFlashEvent : redEvent
	{
		public WantedBarEndFlashEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
