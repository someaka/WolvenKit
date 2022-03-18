
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MovableWallScreenController : DoorController
	{
		public MovableWallScreenController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
