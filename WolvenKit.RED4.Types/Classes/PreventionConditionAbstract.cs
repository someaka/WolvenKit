
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionConditionAbstract : AIbehaviorconditionScript
	{
		public PreventionConditionAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
