
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameTooltipHideRequest : redEvent
	{
		public MinigameTooltipHideRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
