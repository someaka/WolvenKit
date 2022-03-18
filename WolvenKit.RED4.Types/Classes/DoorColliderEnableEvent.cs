
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorColliderEnableEvent : redEvent
	{
		public DoorColliderEnableEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
