
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataAttachableObject_Record : gamedataSpawnableObject_Record
	{
		public gamedataAttachableObject_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
