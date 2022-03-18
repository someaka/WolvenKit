
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlertedState : ChangeHighLevelStateAbstract
	{
		public AlertedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
