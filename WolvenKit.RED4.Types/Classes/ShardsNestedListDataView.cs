
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardsNestedListDataView : VirtualNestedListDataView
	{
		public ShardsNestedListDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
