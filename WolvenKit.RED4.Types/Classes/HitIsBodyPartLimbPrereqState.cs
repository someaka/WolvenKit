
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsBodyPartLimbPrereqState : GenericHitPrereqState
	{
		public HitIsBodyPartLimbPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
