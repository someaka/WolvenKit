
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsReprimandOngoing : AIAutonomousConditions
	{
		public IsReprimandOngoing()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
