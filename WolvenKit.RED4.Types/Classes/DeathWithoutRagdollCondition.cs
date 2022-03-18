
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathWithoutRagdollCondition : AIDeathConditions
	{
		public DeathWithoutRagdollCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
