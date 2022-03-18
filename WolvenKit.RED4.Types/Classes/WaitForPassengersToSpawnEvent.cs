
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitForPassengersToSpawnEvent : redEvent
	{
		public WaitForPassengersToSpawnEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
