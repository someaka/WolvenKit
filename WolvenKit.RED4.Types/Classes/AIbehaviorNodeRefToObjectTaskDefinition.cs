
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorNodeRefToObjectTaskDefinition : AIbehaviorNodeRefConverterTaskDefinition
	{
		public AIbehaviorNodeRefToObjectTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
