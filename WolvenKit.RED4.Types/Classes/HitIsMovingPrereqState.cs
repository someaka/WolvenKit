
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsMovingPrereqState : GenericHitPrereqState
	{
		public HitIsMovingPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
