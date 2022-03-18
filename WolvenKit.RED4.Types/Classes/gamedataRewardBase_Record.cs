
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataRewardBase_Record : gamedataTweakDBRecord
	{
		public gamedataRewardBase_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
