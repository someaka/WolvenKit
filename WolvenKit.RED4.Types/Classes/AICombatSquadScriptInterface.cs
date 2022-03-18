
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICombatSquadScriptInterface : AISquadScriptInterface
	{
		public AICombatSquadScriptInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
