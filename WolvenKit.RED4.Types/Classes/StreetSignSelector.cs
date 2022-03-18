
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StreetSignSelector : inkTweakDBIDSelector
	{
		public StreetSignSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
