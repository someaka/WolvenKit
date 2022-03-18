
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeDespawnRequestEvent : redEvent
	{
		public GrenadeDespawnRequestEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
