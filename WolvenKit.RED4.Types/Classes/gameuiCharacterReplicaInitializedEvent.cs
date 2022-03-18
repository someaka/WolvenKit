
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterReplicaInitializedEvent : redEvent
	{
		public gameuiCharacterReplicaInitializedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
