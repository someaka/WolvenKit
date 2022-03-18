
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsConnectedToSecuritySystem : AIAutonomousConditions
	{
		public IsConnectedToSecuritySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
