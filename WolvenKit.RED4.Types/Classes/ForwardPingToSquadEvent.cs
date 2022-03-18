
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForwardPingToSquadEvent : redEvent
	{
		public ForwardPingToSquadEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
