
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSetBackgroundEvent : redEvent
	{
		public gameuiSetBackgroundEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
