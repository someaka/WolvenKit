
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameComponentsStateSystem : gameIComponentsStateSystem
	{
		public gameComponentsStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
