
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderController : ScriptableDeviceComponent
	{
		public LadderController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
