
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneExitingDecisions : VehicleTransition
	{
		public SceneExitingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
