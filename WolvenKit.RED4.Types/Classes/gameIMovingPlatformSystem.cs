
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMovingPlatformSystem : gameIGameSystem
	{
		public gameIMovingPlatformSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
