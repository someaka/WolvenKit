
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceUpdateDefaultHighlightEvent : redEvent
	{
		public ForceUpdateDefaultHighlightEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
