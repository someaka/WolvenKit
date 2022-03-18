
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPopulationSystem : gameIGameSystem
	{
		public gameIPopulationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
