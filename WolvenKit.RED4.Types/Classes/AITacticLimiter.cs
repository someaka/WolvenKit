
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITacticLimiter : AICoverSelectionParameters
	{
		public AITacticLimiter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
