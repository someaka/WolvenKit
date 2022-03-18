
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entDebugPositionProvider : entIPositionProvider
	{
		public entDebugPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
