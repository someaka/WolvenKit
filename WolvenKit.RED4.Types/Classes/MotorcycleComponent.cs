
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MotorcycleComponent : VehicleComponent
	{
		public MotorcycleComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
