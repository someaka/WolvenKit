
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatsSystem : gameIStatsSystem
	{
		public gameStatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
