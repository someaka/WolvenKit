
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftMovementLoadEvent : redEvent
	{
		public LiftMovementLoadEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
