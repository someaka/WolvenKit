
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitFlagPrereqState : GenericHitPrereqState
	{
		public HitFlagPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
