
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFuncPositionProvider : entIPositionProvider
	{
		public entFuncPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
