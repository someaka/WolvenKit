
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WindowController : DoorController
	{
		public WindowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
