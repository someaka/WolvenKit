
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpeakerController : ScriptableDeviceComponent
	{
		public SpeakerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
