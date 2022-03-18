
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadScriptInterface : IScriptable
	{
		public AISquadScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
