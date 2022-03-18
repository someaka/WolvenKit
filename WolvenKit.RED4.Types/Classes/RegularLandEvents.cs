
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegularLandEvents : AbstractLandEvents
	{
		public RegularLandEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
