
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntitySpawnerEventsBroadcasterImpl : gameIEntitySpawnerEventsBroadcaster
	{
		public gameEntitySpawnerEventsBroadcasterImpl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
