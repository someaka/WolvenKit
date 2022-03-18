
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsNPCAloneInVehicle : AIVehicleConditionAbstract
	{
		public IsNPCAloneInVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
