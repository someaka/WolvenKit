
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIPersistencySystem : gameIGameSystem
	{
		public gameIPersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
