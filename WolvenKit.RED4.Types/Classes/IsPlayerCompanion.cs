
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerCompanion : AIAutonomousConditions
	{
		public IsPlayerCompanion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
