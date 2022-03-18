
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class gamePlayerStatsListener : gamePuppetStatsListener
	{
		public gamePlayerStatsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
