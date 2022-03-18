
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerController : TerminalController
	{
		public ComputerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
