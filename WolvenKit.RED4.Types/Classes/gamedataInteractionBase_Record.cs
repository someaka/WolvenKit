
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataInteractionBase_Record : gamedataTweakDBRecord
	{
		public gamedataInteractionBase_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
