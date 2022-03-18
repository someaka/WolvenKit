
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDeviceInteractionManager : gameIGameSystem
	{
		public gameIDeviceInteractionManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
