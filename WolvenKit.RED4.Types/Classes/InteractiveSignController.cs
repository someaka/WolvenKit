
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractiveSignController : ScriptableDeviceComponent
	{
		public InteractiveSignController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
