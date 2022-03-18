
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LcdScreenController : ScriptableDeviceComponent
	{
		public LcdScreenController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
