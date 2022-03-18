
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceComponent : gameComponent
	{
		public gameDeviceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
