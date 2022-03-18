
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricBoxController : MasterController
	{
		public ElectricBoxController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
