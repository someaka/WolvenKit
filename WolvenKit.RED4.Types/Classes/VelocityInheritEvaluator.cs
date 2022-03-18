
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VelocityInheritEvaluator : PhysicsParticleInitializer
	{
		public VelocityInheritEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
