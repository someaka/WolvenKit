
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalFileEntry : gameJournalContainerEntry
	{
		public gameJournalFileEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
