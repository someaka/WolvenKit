
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIJournalManager : gameIReplicatedGameSystem
	{
		public gameIJournalManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
