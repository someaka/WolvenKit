
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISmartSpotInstance : AISpotInstance
	{
		public AISmartSpotInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
