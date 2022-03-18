
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NextFrameEvent : redEvent
	{
		public NextFrameEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
