
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestStatPoolListener : gameIStatPoolsListener
	{
		public questQuestStatPoolListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
