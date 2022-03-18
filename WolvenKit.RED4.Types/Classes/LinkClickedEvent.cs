
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LinkClickedEvent : redEvent
	{
		public LinkClickedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
