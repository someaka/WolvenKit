
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatState : ChangeHighLevelStateAbstract
	{
		public CombatState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
