
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RestedEvents : StaminaEventsTransition
	{
		public RestedEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
