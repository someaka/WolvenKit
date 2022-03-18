
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IntercomController : ScriptableDeviceComponent
	{
		public IntercomController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
