
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareWaitForUnequipDecisions : LeftHandCyberwareTransition
	{
		public LeftHandCyberwareWaitForUnequipDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
