
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleWindowState : ChangeStanceStateAbstract
	{
		public VehicleWindowState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
