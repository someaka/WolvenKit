
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMenuInstance_SpawnAddressedEvent : inkMenuInstance_SpawnEvent
	{
		public inkMenuInstance_SpawnAddressedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
