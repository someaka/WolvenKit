
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareEquipEvents : LeftHandCyberwareEventsTransition
	{
		public LeftHandCyberwareEquipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
