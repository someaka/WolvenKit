
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableAreaIndicatorEvent : redEvent
	{
		public DisableAreaIndicatorEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
