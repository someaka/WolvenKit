
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneOffEvents : ComDeviceTransition
	{
		public PhoneOffEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
