
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameExternalMovementCameraDataEvent : redEvent
	{
		public gameExternalMovementCameraDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
