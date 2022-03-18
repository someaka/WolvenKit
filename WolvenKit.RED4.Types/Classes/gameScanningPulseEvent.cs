
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningPulseEvent : redEvent
	{
		public gameScanningPulseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
