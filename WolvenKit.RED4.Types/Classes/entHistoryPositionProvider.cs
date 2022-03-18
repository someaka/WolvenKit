
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entHistoryPositionProvider : entIPositionProvider
	{
		public entHistoryPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
