
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatLastKnownPositionProvider : AIThreatPositionProvider
	{
		public AIThreatLastKnownPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
