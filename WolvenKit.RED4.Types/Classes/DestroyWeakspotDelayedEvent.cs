
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestroyWeakspotDelayedEvent : redEvent
	{
		public DestroyWeakspotDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
