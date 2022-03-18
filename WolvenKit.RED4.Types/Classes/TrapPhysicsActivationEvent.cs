
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrapPhysicsActivationEvent : redEvent
	{
		public TrapPhysicsActivationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
