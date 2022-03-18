
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerVisibilityChangedEvent : redEvent
	{
		public gameContainerVisibilityChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
