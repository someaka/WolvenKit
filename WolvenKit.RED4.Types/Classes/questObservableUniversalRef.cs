
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObservableUniversalRef : questUniversalRef
	{
		public questObservableUniversalRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
