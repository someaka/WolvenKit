
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartWindowController : ComputerController
	{
		public SmartWindowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
