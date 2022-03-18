
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MouseCursorRootController : CursorRootController
	{
		public MouseCursorRootController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
