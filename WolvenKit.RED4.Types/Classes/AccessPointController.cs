
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccessPointController : MasterController
	{
		public AccessPointController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
