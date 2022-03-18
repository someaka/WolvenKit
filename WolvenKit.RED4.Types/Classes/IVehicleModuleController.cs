
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IVehicleModuleController : inkWidgetLogicController
	{
		public IVehicleModuleController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
