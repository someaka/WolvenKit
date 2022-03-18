
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleUnableToStartPanicDriving : redEvent
	{
		public vehicleUnableToStartPanicDriving()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
