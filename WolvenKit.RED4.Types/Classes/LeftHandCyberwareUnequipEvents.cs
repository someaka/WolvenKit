
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareUnequipEvents : LeftHandCyberwareEventsTransition
	{
		public LeftHandCyberwareUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
