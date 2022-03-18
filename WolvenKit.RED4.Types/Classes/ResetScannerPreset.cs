
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetScannerPreset : redEvent
	{
		public ResetScannerPreset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
