
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalBriefing : gameJournalFileEntry
	{
		public gameJournalBriefing()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
