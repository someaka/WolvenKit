
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhysicsParticleInitializer : ISerializable
	{
		public PhysicsParticleInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
