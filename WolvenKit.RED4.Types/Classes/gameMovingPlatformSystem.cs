
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformSystem : gameIMovingPlatformSystem
	{
		public gameMovingPlatformSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
