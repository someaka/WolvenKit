
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWeakScriptableDataSourceWrapper : inkBaseWeakScriptableDataSource
	{
		public inkWeakScriptableDataSourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
