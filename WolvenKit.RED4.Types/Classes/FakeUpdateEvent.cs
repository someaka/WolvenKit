
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FakeUpdateEvent : gameTickableEvent
	{
		public FakeUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
