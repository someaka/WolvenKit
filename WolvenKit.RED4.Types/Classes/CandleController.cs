
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CandleController : ScriptableDeviceComponent
	{
		public CandleController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
