
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatConditions : AIAutonomousConditions
	{
		public CombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
