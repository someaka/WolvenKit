
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsFriendlyToPlayer : AIAutonomousConditions
	{
		public IsFriendlyToPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
