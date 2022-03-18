
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCameraSystem : gameICameraSystem
	{
		public gameCameraSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
