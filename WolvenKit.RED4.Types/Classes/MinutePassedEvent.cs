
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinutePassedEvent : redEvent
	{
		public MinutePassedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
