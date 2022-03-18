
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionSpotInstance : AISmartSpotInstance
	{
		public AIActionSpotInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
