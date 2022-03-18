
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameBlackboardSystem : gameIBlackboardSystem
	{
		public gameBlackboardSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
