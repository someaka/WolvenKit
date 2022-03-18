
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemountingMountableComponent : entIComponent
	{
		public gamemountingMountableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
