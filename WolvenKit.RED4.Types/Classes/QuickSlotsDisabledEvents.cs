
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsDisabledEvents : QuickSlotsEvents
	{
		public QuickSlotsDisabledEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
