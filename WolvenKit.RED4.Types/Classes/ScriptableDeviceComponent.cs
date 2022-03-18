
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptableDeviceComponent : gameDeviceComponent
	{
		public ScriptableDeviceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
