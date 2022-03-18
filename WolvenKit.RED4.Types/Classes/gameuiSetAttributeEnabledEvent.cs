
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSetAttributeEnabledEvent : redEvent
	{
		public gameuiSetAttributeEnabledEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
