
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvalidateTooltipOwnerEvent : redEvent
	{
		public InvalidateTooltipOwnerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
