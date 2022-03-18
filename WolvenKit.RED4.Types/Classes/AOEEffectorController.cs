
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AOEEffectorController : ScriptableDeviceComponent
	{
		public AOEEffectorController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
