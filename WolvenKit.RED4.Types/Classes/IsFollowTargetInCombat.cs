
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsFollowTargetInCombat : AIAutonomousConditions
	{
		public IsFollowTargetInCombat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
