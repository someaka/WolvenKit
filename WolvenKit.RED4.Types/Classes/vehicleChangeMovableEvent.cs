
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChangeMovableEvent : redEvent
	{
		public vehicleChangeMovableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
