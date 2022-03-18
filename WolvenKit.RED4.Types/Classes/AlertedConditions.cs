
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlertedConditions : AIAutonomousConditions
	{
		public AlertedConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
