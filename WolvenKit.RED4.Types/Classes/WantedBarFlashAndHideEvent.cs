
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WantedBarFlashAndHideEvent : redEvent
	{
		public WantedBarFlashAndHideEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
