
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StopShortGlitchEvent : redEvent
	{
		public StopShortGlitchEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
