
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleMoveSystem : vehicleIMoveSystem
	{
		public vehicleMoveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
