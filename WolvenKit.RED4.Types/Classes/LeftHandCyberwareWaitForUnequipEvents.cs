
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareWaitForUnequipEvents : LeftHandCyberwareEventsTransition
	{
		public LeftHandCyberwareWaitForUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
