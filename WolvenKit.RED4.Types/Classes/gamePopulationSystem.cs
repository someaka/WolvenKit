
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePopulationSystem : gameIPopulationSystem
	{
		public gamePopulationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
