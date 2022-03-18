
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetComponent : entIComponent
	{
		public gameMuppetComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
