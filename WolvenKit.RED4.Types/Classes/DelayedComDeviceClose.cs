
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedComDeviceClose : redEvent
	{
		public DelayedComDeviceClose()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
