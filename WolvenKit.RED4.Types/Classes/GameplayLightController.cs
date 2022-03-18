
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayLightController : ElectricLightController
	{
		public GameplayLightController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
