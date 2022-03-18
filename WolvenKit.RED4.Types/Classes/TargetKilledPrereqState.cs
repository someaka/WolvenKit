
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetKilledPrereqState : GenericHitPrereqState
	{
		public TargetKilledPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
