
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetRawInput : gameMuppetComponent
	{
		public gameMuppetRawInput()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
