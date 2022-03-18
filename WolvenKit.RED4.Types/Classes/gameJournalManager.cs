
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalManager : gameIJournalManager
	{
		public gameJournalManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
