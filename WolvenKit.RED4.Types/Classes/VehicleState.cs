
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleState : ChangeStanceStateAbstract
	{
		public VehicleState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
