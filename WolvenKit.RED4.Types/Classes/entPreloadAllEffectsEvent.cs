
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPreloadAllEffectsEvent : redEvent
	{
		public entPreloadAllEffectsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
