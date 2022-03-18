
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclesManagerDataView : inkScriptableDataViewWrapper
	{
		public VehiclesManagerDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
