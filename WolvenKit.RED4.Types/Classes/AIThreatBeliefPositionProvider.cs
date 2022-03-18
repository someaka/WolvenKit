
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatBeliefPositionProvider : AIThreatPositionProvider
	{
		public AIThreatBeliefPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
