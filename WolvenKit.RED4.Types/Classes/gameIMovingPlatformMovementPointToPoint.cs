
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIMovingPlatformMovementPointToPoint : gameIMovingPlatformMovement
	{
		public gameIMovingPlatformMovementPointToPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
