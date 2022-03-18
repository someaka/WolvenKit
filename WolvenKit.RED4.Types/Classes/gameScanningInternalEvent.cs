
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningInternalEvent : redEvent
	{
		public gameScanningInternalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
