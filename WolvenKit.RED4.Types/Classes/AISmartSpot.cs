
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISmartSpot : AISpot
	{
		public AISmartSpot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
