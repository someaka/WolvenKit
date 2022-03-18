
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitIsRicochetPrereqState : GenericHitPrereqState
	{
		public HitIsRicochetPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
