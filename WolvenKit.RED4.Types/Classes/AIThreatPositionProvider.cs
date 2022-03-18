
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatPositionProvider : entIPositionProvider
	{
		public AIThreatPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
