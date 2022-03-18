
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitStatPoolPrereqState : GenericHitPrereqState
	{
		public HitStatPoolPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
