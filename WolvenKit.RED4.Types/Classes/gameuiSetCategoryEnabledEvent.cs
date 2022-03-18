
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSetCategoryEnabledEvent : redEvent
	{
		public gameuiSetCategoryEnabledEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
