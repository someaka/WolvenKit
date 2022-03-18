
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsInVehicle : AIVehicleConditionAbstract
	{
		public IsInVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
