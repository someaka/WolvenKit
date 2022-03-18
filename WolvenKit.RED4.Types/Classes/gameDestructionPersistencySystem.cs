
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDestructionPersistencySystem : gameIDestructionPersistencySystem
	{
		public gameDestructionPersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
