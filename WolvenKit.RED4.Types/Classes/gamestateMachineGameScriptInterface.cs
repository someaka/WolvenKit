
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineGameScriptInterface : gamestateMachineScriptInterface
	{
		public gamestateMachineGameScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
