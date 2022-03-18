
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGarageComponent : gameComponent
	{
		public vehicleGarageComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
