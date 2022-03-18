
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SyncAnimDeathTask : WithoutHitDataDeathTask
	{
		public SyncAnimDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
