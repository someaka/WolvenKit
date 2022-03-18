
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InspectionDecisions : HighLevelTransition
	{
		public InspectionDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
