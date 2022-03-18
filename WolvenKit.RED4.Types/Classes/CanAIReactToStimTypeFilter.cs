
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanAIReactToStimTypeFilter : gameEffectObjectSingleFilter_Scripted
	{
		public CanAIReactToStimTypeFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
