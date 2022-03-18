
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutoKillDelayEvent : redEvent
	{
		public AutoKillDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
