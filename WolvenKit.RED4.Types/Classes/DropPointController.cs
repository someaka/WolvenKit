
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointController : ScriptableDeviceComponent
	{
		public DropPointController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
