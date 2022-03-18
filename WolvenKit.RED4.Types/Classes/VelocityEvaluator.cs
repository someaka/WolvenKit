
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VelocityEvaluator : PhysicsParticleInitializer
	{
		public VelocityEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
