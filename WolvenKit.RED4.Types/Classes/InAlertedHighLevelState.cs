
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InAlertedHighLevelState : AINPCHighLevelStateCheck
	{
		public InAlertedHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
