
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleDoorInteractionEvent : redEvent
	{
		public ToggleDoorInteractionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
