
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workReactionFinishedEvent : redEvent
	{
		public workReactionFinishedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
