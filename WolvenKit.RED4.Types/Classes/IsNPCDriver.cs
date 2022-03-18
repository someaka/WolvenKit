
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsNPCDriver : AIVehicleConditionAbstract
	{
		public IsNPCDriver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
