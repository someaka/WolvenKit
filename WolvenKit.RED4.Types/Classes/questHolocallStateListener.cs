
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHolocallStateListener : worldIQuestPrefabStateListener
	{
		public questHolocallStateListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
