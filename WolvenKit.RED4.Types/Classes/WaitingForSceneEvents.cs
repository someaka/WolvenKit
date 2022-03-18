
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitingForSceneEvents : VehicleTransition
	{
		public WaitingForSceneEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
