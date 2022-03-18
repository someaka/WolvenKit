
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActivateTPPRepresentationEvent : redEvent
	{
		public gameActivateTPPRepresentationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
