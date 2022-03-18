
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRemoveCooldownEvent : gameCooldownSystemEvent
	{
		public gameRemoveCooldownEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
