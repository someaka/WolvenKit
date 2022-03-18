
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuperheroLandEvents : AbstractLandEvents
	{
		public SuperheroLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
