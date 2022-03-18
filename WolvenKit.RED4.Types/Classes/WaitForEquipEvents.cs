
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WaitForEquipEvents : UpperBodyEventsTransition
	{
		public WaitForEquipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
