
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseNetworkSystemController : MasterController
	{
		public BaseNetworkSystemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
