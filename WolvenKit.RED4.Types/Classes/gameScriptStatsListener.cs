
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptStatsListener : gameIStatsListener
	{
		public gameScriptStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
