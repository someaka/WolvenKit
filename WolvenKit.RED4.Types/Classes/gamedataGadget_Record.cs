
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataGadget_Record : gamedataWeaponItem_Record
	{
		public gamedataGadget_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
