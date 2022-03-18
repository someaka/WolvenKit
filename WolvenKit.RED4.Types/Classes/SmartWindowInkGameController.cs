
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartWindowInkGameController : ComputerInkGameController
	{
		public SmartWindowInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
