
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ControlsInactiveDecisions : BraindanceControlsTransition
	{
		public ControlsInactiveDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
