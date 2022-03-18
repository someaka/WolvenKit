
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MenuItemDelayedUpdate : redEvent
	{
		public MenuItemDelayedUpdate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
