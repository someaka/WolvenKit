
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CanMountVehicle : AIVehicleConditionAbstract
	{
		public CanMountVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
