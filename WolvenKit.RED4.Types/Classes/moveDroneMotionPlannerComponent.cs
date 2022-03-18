
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveDroneMotionPlannerComponent : moveMotionPlannerComponent
	{
		public moveDroneMotionPlannerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
