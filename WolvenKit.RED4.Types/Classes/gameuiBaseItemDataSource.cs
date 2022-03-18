
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseItemDataSource : inkAbstractDataSourceWrapper
	{
		public gameuiBaseItemDataSource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
