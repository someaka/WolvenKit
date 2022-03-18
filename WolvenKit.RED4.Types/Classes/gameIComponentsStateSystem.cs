
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIComponentsStateSystem : gameIGameSystem
	{
		public gameIComponentsStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
