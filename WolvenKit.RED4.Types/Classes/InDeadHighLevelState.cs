
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InDeadHighLevelState : AINPCHighLevelStateCheck
	{
		public InDeadHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
