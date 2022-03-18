
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhonePrefabsListener : worldIQuestPrefabStateListener
	{
		public questPhonePrefabsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
