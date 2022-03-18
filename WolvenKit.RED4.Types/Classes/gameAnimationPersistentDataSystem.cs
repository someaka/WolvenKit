
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimationPersistentDataSystem : gameIGameSystem
	{
		public gameAnimationPersistentDataSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
