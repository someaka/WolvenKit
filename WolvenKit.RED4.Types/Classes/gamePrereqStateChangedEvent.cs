
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqStateChangedEvent : redEvent
	{
		public gamePrereqStateChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
