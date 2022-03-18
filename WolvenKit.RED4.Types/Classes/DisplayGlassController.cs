
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisplayGlassController : ScriptableDeviceComponent
	{
		public DisplayGlassController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
