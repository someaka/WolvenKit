
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnBoxEvaluator : PhysicsParticleInitializer
	{
		public SpawnBoxEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
