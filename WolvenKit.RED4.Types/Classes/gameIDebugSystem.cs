
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDebugSystem : gameIGameSystem
	{
		public gameIDebugSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
