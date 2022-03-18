
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkScriptableDataViewWrapper : inkBaseScriptableDataSource
	{
		public inkScriptableDataViewWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
