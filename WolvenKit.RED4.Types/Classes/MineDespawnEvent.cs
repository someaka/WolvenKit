
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MineDespawnEvent : redEvent
	{
		public MineDespawnEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
