
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PortalControllerPS : ScriptableDeviceComponentPS
	{
		public PortalControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
