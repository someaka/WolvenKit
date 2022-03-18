
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePersistencySystem : gameIPersistencySystem
	{
		public gamePersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
