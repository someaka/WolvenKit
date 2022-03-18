
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetBlackboardsComponent : gameMuppetComponent
	{
		public gameMuppetBlackboardsComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
