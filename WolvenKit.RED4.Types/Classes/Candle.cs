
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Candle : gameObject
	{
		public Candle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
