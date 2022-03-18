
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetLocomotionComponent : gameMuppetComponent
	{
		public gameMuppetLocomotionComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
