
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScanPlayerDelayEvent : redEvent
	{
		public ScanPlayerDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
