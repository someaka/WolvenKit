
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptableDataSourceWrapper : inkBaseScriptableDataSource
	{
		public inkScriptableDataSourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
