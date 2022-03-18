
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathMenuDelayEvent : redEvent
	{
		public DeathMenuDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
