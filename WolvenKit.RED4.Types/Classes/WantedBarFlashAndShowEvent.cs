
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WantedBarFlashAndShowEvent : redEvent
	{
		public WantedBarFlashAndShowEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
