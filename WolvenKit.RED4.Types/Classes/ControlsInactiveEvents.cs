
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ControlsInactiveEvents : BraindanceControlsTransition
	{
		public ControlsInactiveEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
