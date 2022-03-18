
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VeryHardLandEvents : FailedLandingAbstractEvents
	{
		public VeryHardLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
