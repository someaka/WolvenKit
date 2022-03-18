
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnterVehicle : AIVehicleTaskAbstract
	{
		public EnterVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
