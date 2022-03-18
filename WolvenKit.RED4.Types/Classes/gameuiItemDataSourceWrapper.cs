
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiItemDataSourceWrapper : gameuiBaseItemDataSource
	{
		public gameuiItemDataSourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
