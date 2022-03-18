
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBehaviourSpotInstance : AISmartSpotInstance
	{
		public AIBehaviourSpotInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
