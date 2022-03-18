
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetStats : gameMuppetComponent
	{
		public gameMuppetStats()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
