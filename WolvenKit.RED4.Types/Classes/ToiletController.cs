
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToiletController : ScriptableDeviceComponent
	{
		public ToiletController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
