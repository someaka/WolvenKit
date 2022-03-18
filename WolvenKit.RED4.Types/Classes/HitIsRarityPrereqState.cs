
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsRarityPrereqState : GenericHitPrereqState
	{
		public HitIsRarityPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
