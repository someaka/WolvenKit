
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ControlsActiveDecisions : BraindanceControlsTransition
	{
		public ControlsActiveDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
