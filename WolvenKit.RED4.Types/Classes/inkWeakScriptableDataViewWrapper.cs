
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWeakScriptableDataViewWrapper : inkBaseWeakScriptableDataSource
	{
		public inkWeakScriptableDataViewWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
