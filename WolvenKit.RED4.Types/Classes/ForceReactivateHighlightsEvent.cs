
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceReactivateHighlightsEvent : redEvent
	{
		public ForceReactivateHighlightsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
