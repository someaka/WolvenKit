
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAbortSummoningActionEvent : gameActionEvent
	{
		public vehicleAbortSummoningActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
