
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HardLandEvents : FailedLandingAbstractEvents
	{
		public HardLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
