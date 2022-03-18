
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataCarriableObject_Record : gamedataSpawnableObject_Record
	{
		public gamedataCarriableObject_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
