
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNodeRefToInstanceTaskDefinition : AIbehaviorNodeRefConverterTaskDefinition
	{
		public AIbehaviorNodeRefToInstanceTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
