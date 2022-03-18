
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IParticleModificator : IParticleInitializer
	{
		public IParticleModificator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
