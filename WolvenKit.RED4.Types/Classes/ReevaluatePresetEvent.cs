
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReevaluatePresetEvent : redEvent
	{
		public ReevaluatePresetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
