
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleDamageStageTurnOffEvent : redEvent
	{
		public VehicleDamageStageTurnOffEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
