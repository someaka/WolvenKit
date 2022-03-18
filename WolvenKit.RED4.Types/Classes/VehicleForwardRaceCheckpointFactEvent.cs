
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleForwardRaceCheckpointFactEvent : redEvent
	{
		public VehicleForwardRaceCheckpointFactEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
