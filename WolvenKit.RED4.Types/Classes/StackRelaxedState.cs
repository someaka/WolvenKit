
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StackRelaxedState : StackChangeHighLevelStateAbstract
	{
		public StackRelaxedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
