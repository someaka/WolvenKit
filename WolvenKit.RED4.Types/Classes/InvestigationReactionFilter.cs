
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvestigationReactionFilter : gameEffectObjectSingleFilter_Scripted
	{
		public InvestigationReactionFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
