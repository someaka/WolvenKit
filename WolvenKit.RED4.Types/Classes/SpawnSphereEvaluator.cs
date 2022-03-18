
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnSphereEvaluator : PhysicsParticleInitializer
	{
		public SpawnSphereEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
