
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareLoopEvents : LeftHandCyberwareEventsTransition
	{
		public LeftHandCyberwareLoopEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
