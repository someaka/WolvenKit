
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GamepadCursorRootController : CursorRootController
	{
		public GamepadCursorRootController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
