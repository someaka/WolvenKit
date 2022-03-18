
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePSChangedEvent : redEvent
	{
		public gamePSChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
