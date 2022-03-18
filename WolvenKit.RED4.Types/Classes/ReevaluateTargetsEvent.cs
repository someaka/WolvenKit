
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReevaluateTargetsEvent : redEvent
	{
		public ReevaluateTargetsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
