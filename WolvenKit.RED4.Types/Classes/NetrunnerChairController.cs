
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerChairController : ScriptableDeviceComponent
	{
		public NetrunnerChairController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
