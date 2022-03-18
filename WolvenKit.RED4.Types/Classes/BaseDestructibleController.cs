
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseDestructibleController : ScriptableDeviceComponent
	{
		public BaseDestructibleController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
