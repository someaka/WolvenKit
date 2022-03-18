
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorInstantTaskNodeDefinition : AIbehaviorTaskNodeDefinition
	{
		public AIbehaviorInstantTaskNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
