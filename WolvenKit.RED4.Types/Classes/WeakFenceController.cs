
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFenceController : ScriptableDeviceComponent
	{
		public WeakFenceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
