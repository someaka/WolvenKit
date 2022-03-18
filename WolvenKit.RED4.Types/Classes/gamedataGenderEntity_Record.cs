
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataGenderEntity_Record : gamedataTweakDBRecord
	{
		public gamedataGenderEntity_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
