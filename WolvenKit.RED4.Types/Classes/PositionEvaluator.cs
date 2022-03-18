
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PositionEvaluator : PhysicsParticleInitializer
	{
		public PositionEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
