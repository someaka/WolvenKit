
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitDamageOverTimePrereqState : GenericHitPrereqState
	{
		public HitDamageOverTimePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
