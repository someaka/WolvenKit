
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleMoveSystemStopEvent : gameActionEvent
	{
		public vehicleMoveSystemStopEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
