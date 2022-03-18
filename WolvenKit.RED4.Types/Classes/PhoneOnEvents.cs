
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneOnEvents : ComDeviceTransition
	{
		public PhoneOnEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
