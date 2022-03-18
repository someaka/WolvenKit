
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReevaluateOxygenEvent : redEvent
	{
		public ReevaluateOxygenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
