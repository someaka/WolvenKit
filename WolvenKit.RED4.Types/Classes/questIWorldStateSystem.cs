
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIWorldStateSystem : gameIGameSystem
	{
		public questIWorldStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
