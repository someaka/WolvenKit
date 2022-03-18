
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAppearanceChangeFinishEvent : redEvent
	{
		public entAppearanceChangeFinishEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
