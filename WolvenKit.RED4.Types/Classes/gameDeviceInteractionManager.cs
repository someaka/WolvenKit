
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceInteractionManager : gameIDeviceInteractionManager
	{
		public gameDeviceInteractionManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
