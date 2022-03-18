
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayerTierComponent : entIComponent
	{
		public gamePlayerTierComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
