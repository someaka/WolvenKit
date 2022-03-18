
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TerminalController : MasterController
	{
		public TerminalController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
