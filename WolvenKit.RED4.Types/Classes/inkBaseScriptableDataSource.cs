
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBaseScriptableDataSource : inkAbstractDataSourceWrapper
	{
		public inkBaseScriptableDataSource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
