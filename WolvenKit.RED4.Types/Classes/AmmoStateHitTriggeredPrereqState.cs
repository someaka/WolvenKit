
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateHitTriggeredPrereqState : GenericHitPrereqState
	{
		public AmmoStateHitTriggeredPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
