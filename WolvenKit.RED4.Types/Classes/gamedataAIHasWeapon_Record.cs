
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAIHasWeapon_Record : gamedataAIActionSubCondition_Record
	{
		public gamedataAIHasWeapon_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
