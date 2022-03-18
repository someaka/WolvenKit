
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimOnStateChangedEvent : redEvent
	{
		public entAnimOnStateChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
