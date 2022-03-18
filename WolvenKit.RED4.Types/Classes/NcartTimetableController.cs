
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimetableController : ScriptableDeviceComponent
	{
		public NcartTimetableController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
