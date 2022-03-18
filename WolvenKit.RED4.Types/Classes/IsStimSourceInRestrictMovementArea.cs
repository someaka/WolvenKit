
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsStimSourceInRestrictMovementArea : RestrictedMovementAreaCondition
	{
		public IsStimSourceInRestrictMovementArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
