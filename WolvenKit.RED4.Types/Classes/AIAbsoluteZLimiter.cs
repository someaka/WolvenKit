
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAbsoluteZLimiter : AICoverSelectionParameters
	{
		public AIAbsoluteZLimiter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
