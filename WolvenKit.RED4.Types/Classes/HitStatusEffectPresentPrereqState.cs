
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitStatusEffectPresentPrereqState : GenericHitPrereqState
	{
		public HitStatusEffectPresentPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
