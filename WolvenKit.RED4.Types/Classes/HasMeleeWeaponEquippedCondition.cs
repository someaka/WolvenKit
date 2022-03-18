
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasMeleeWeaponEquippedCondition : workIScriptedCondition
	{
		public HasMeleeWeaponEquippedCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
