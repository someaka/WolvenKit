
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaminaEventsTransition : StaminaTransition
	{
		public StaminaEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
