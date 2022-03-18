
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatSharedLastKnownPositionProvider : AIThreatPositionProvider
	{
		public AIThreatSharedLastKnownPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
