
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIReturnToRestrictMovementAreaCondition : RestrictedMovementAreaCondition
	{
		public AIReturnToRestrictMovementAreaCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
