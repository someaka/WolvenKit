
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeathLandEvents : FailedLandingAbstractEvents
	{
		public DeathLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
