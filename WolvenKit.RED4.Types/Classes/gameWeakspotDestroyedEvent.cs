
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWeakspotDestroyedEvent : redEvent
	{
		public gameWeakspotDestroyedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
