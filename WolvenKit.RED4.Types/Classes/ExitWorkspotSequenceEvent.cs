
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExitWorkspotSequenceEvent : redEvent
	{
		public ExitWorkspotSequenceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
