
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FailedLandingAbstractEvents : AbstractLandEvents
	{
		public FailedLandingAbstractEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
