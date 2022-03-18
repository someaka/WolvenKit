
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneMessageHidePopupEvent : redEvent
	{
		public PhoneMessageHidePopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
