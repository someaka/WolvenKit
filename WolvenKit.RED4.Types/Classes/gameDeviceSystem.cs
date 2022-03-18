
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceSystem : gameIDeviceSystem
	{
		public gameDeviceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
