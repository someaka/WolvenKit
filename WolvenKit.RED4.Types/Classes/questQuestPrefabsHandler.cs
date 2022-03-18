
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPrefabsHandler : worldIQuestPrefabStateListener
	{
		public questQuestPrefabsHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
