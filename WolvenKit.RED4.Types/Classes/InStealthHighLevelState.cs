
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InStealthHighLevelState : AINPCHighLevelStateCheck
	{
		public InStealthHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
