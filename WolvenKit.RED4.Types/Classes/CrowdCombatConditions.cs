
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrowdCombatConditions : AIAutonomousConditions
	{
		public CrowdCombatConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
