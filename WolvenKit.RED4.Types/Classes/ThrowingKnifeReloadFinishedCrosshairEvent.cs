
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowingKnifeReloadFinishedCrosshairEvent : redEvent
	{
		public ThrowingKnifeReloadFinishedCrosshairEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
