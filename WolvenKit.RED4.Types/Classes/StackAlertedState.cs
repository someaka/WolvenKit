
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StackAlertedState : StackChangeHighLevelStateAbstract
	{
		public StackAlertedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
