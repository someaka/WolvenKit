
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputHandlerComponent : entIComponent
	{
		public gameMuppetInputHandlerComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
