
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckIfPatrolAllowed : AIDebugConditions
	{
		public CheckIfPatrolAllowed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
