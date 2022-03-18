
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameWorldBoundarySystem : gameIWorldBoundarySystem
	{
		public gameWorldBoundarySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
