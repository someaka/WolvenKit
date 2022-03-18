
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReturnToDeviceScreenEvent : redEvent
	{
		public ReturnToDeviceScreenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
