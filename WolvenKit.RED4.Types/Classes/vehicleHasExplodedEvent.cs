
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleHasExplodedEvent : redEvent
	{
		public vehicleHasExplodedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
