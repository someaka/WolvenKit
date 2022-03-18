
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasVehicleAssigned : AIVehicleConditionAbstract
	{
		public HasVehicleAssigned()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
