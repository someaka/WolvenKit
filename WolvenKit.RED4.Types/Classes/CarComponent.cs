
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CarComponent : VehicleComponent
	{
		public CarComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
