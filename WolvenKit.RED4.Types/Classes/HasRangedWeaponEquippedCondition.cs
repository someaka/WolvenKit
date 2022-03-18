
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasRangedWeaponEquippedCondition : workIScriptedCondition
	{
		public HasRangedWeaponEquippedCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
