
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseOnExitShapeEvent : senseVisibilityEvent
	{
		public senseOnExitShapeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
