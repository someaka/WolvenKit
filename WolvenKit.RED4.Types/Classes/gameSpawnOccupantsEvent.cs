
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSpawnOccupantsEvent : redEvent
	{
		public gameSpawnOccupantsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
