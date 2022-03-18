
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwimmingDeathEvents : DeathEvents
	{
		public SwimmingDeathEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
