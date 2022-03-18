
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class hubStaticSelectorPostArrangeEvent : redEvent
	{
		public hubStaticSelectorPostArrangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
