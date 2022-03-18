
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBaseVariantDataSource : inkAbstractDataSourceWrapper
	{
		public inkBaseVariantDataSource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
