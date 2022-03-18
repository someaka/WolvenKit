
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatSharedBeliefPositionProvider : AIThreatPositionProvider
	{
		public AIThreatSharedBeliefPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
