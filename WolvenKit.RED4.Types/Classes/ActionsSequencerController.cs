
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionsSequencerController : ScriptableDeviceComponent
	{
		public ActionsSequencerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
