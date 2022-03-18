
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRandomCoverSelection : AICoverSelectionParameters
	{
		public AIRandomCoverSelection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
