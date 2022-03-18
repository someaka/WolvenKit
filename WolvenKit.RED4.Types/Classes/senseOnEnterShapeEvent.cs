
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseOnEnterShapeEvent : senseVisibilityEvent
	{
		public senseOnEnterShapeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
