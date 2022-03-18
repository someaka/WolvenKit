
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StackChangeHighLevelStateAbstract : AIbehaviortaskStackScript
	{
		public StackChangeHighLevelStateAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
