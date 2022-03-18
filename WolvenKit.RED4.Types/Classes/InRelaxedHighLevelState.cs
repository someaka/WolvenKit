
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InRelaxedHighLevelState : AINPCHighLevelStateCheck
	{
		public InRelaxedHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
