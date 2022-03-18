
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityPositionProvider : entIPositionProvider
	{
		public entEntityPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
