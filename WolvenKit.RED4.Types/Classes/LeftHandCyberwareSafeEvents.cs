
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareSafeEvents : LeftHandCyberwareEventsTransition
	{
		public LeftHandCyberwareSafeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
