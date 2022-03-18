
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitingForSceneDecisions : VehicleTransition
	{
		public WaitingForSceneDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
