
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetStatsListener : gameIStatsListener
	{
		public gamePuppetStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
