
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayLightControllerPS : ElectricLightControllerPS
	{
		public GameplayLightControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
