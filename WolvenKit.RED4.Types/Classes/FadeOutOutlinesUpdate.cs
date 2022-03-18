
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FadeOutOutlinesUpdate : gameTickableEvent
	{
		public FadeOutOutlinesUpdate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
