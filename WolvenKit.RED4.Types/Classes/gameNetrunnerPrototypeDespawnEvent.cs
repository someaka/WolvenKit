
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeDespawnEvent : redEvent
	{
		public gameNetrunnerPrototypeDespawnEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
