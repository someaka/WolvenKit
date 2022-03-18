
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAvoidLineOfSightCoverSelection : AICoverSelectionParameters
	{
		public AIAvoidLineOfSightCoverSelection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
