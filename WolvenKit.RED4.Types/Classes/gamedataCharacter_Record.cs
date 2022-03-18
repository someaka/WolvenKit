
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataCharacter_Record : gamedataSpawnableObject_Record
	{
		public gamedataCharacter_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
