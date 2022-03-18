
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedHUDInitializeEvent : redEvent
	{
		public DelayedHUDInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
