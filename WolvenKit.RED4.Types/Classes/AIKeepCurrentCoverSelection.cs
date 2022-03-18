
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIKeepCurrentCoverSelection : AICoverSelectionParameters
	{
		public AIKeepCurrentCoverSelection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
