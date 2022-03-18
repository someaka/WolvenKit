
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITrafficMovementSystem : AIITrafficMovementSystem
	{
		public AITrafficMovementSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
