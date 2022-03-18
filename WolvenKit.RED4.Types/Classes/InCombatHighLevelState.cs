
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InCombatHighLevelState : AINPCHighLevelStateCheck
	{
		public InCombatHighLevelState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
