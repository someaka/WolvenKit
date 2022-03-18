
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwapMeshDelayedEvent : redEvent
	{
		public SwapMeshDelayedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
