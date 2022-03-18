
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalPrimaryFolderEntry : gameJournalFolderEntry
	{
		public gameJournalPrimaryFolderEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
