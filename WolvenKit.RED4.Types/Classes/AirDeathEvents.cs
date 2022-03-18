
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AirDeathEvents : DeathEvents
	{
		public AirDeathEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
