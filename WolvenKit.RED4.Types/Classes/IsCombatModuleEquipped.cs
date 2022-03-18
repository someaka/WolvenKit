
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsCombatModuleEquipped : AIAutonomousConditions
	{
		public IsCombatModuleEquipped()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
