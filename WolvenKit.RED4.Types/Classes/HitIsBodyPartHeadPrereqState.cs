
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsBodyPartHeadPrereqState : GenericHitPrereqState
	{
		public HitIsBodyPartHeadPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
