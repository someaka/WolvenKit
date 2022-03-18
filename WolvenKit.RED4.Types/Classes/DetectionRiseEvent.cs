
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DetectionRiseEvent : senseVisibilityEvent
	{
		public DetectionRiseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
