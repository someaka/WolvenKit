
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeactivateTPPRepresentationEvent : redEvent
	{
		public gameDeactivateTPPRepresentationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
