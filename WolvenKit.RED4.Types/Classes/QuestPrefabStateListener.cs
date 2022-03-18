
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestPrefabStateListener : worldIQuestPrefabStateListener
	{
		public QuestPrefabStateListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
