
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathExitingEvents : ImmediateExitWithForceEvents
	{
		public DeathExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
