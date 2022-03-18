
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataStatusEffectPlayerData_Record : gamedataTweakDBRecord
	{
		public gamedataStatusEffectPlayerData_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
