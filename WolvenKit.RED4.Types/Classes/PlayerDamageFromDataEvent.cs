
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerDamageFromDataEvent : gameTickableEvent
	{
		public PlayerDamageFromDataEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
