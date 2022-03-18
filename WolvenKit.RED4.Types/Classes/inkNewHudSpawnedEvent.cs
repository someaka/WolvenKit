
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkNewHudSpawnedEvent : redEvent
	{
		public inkNewHudSpawnedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
