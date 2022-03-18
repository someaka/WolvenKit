
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathWithoutAnimationCondition : AIDeathConditions
	{
		public DeathWithoutAnimationCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
