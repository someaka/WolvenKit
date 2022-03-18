
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetTickEvent : gameTickableEvent
	{
		public ResetTickEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
