
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIBlackboardSystem : gameIGameSystem
	{
		public gameIBlackboardSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
