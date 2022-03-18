
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkAreaController : MasterController
	{
		public NetworkAreaController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
