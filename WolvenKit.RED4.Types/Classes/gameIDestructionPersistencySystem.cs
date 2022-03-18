
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDestructionPersistencySystem : gameIGameSystem
	{
		public gameIDestructionPersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
