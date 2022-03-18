
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCooldownSystemEvent : redEvent
	{
		public gameCooldownSystemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
