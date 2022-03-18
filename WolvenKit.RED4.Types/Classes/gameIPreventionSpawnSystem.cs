
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPreventionSpawnSystem : gameIGameSystem
	{
		public gameIPreventionSpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
