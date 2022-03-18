
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFreeCameraComponent : gameCameraComponent
	{
		public gameFreeCameraComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
