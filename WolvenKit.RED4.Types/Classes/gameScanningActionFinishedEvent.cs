
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningActionFinishedEvent : redEvent
	{
		public gameScanningActionFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
