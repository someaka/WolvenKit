
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugRemoteConnectionEvent : redEvent
	{
		public DebugRemoteConnectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
