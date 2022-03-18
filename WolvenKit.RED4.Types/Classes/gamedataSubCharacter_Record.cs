
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataSubCharacter_Record : gamedataCharacter_Record
	{
		public gamedataSubCharacter_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
