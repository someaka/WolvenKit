
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CollisionExitingDecisions : ExitingDecisions
	{
		public CollisionExitingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
