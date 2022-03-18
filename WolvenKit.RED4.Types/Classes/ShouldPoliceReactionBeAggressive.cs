
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShouldPoliceReactionBeAggressive : PreventionConditionAbstract
	{
		public ShouldPoliceReactionBeAggressive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
