
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAppearancesReadyTPPRepresentationEvent : redEvent
	{
		public gameAppearancesReadyTPPRepresentationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
