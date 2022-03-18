
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entCollisionPredictionPositionProvider : entIPositionProvider
	{
		public entCollisionPredictionPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
