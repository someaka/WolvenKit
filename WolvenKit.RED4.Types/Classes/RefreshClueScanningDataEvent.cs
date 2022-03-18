
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshClueScanningDataEvent : redEvent
	{
		public RefreshClueScanningDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
