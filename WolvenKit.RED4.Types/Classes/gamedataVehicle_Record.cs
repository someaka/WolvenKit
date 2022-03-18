
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataVehicle_Record : gamedataSpawnableObject_Record
	{
		public gamedataVehicle_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
