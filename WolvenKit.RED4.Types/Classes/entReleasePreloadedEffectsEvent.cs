
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReleasePreloadedEffectsEvent : redEvent
	{
		public entReleasePreloadedEffectsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
