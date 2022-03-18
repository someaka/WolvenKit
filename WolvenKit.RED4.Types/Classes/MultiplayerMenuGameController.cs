
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MultiplayerMenuGameController : PreGameSubMenuGameController
	{
		public MultiplayerMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
