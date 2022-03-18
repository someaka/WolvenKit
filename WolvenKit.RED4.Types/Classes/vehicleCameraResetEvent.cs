
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleCameraResetEvent : redEvent
	{
		public vehicleCameraResetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
