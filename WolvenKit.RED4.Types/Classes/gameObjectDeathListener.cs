
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectDeathListener : gameIStatPoolsListener
	{
		public gameObjectDeathListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
