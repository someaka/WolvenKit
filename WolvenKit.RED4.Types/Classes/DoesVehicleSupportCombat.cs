
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoesVehicleSupportCombat : AIVehicleConditionAbstract
	{
		public DoesVehicleSupportCombat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
