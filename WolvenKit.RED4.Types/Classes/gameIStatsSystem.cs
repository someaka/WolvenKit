
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIStatsSystem : gameIGameSystem
	{
		public gameIStatsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
