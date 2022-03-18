
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataVendorItem_Record : gamedataVendorWare_Record
	{
		public gamedataVendorItem_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
