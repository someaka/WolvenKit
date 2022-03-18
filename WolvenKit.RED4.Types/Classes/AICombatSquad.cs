
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICombatSquad : AISquadBase
	{
		public AICombatSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
