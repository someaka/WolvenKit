
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerChunk : IScriptable
	{
		public ScannerChunk()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
