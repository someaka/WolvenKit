
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InspectionEvents : HighLevelTransition
	{
		public InspectionEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
