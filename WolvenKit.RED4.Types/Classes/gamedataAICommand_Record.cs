
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAICommand_Record : gamedataTweakDBRecord
	{
		public gamedataAICommand_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
