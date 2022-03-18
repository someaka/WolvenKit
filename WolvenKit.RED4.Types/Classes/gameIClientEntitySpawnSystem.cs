
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIClientEntitySpawnSystem : gameIGameSystem
	{
		public gameIClientEntitySpawnSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
