
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIVehicleSystem : gameIGameSystem
	{
		public gameIVehicleSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
