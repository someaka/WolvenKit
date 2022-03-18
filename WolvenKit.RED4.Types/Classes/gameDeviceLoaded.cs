
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceLoaded : redEvent
	{
		public gameDeviceLoaded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
