
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitForEquipDecisions : UpperBodyTransition
	{
		public WaitForEquipDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
