
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GroundDeathEvents : DeathEvents
	{
		public GroundDeathEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
