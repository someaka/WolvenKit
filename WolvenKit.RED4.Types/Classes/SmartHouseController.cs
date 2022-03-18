
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHouseController : MasterController
	{
		public SmartHouseController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
