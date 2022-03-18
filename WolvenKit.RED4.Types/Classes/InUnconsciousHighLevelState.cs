
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InUnconsciousHighLevelState : AINPCHighLevelStateCheck
	{
		public InUnconsciousHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
