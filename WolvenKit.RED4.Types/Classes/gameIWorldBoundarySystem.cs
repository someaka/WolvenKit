
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIWorldBoundarySystem : gameIGameSystem
	{
		public gameIWorldBoundarySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
