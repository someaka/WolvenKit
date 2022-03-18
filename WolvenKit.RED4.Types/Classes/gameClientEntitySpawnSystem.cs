
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameClientEntitySpawnSystem : gameIClientEntitySpawnSystem
	{
		public gameClientEntitySpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
