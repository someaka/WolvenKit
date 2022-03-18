
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDeviceSystem : gameIGameSystem
	{
		public gameIDeviceSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
