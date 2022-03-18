
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AcquireDeviceLink : redEvent
	{
		public AcquireDeviceLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
