
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptableSystem : gameIScriptableSystem
	{
		public gameScriptableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
