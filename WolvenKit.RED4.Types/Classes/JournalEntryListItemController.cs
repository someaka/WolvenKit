
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalEntryListItemController : inkListItemController
	{
		public JournalEntryListItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
