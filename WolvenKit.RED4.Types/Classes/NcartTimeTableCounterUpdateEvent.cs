
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimeTableCounterUpdateEvent : redEvent
	{
		public NcartTimeTableCounterUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
