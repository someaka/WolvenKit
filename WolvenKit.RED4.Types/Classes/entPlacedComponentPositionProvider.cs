
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPlacedComponentPositionProvider : entIPositionProvider
	{
		public entPlacedComponentPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
