
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatPoolDataModifierStatListener : gameIStatsListener
	{
		public gameStatPoolDataModifierStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
