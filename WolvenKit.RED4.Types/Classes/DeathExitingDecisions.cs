
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathExitingDecisions : ExitingDecisions
	{
		public DeathExitingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
