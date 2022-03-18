
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InVehicleDecorator : AIVehicleTaskAbstract
	{
		public InVehicleDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
