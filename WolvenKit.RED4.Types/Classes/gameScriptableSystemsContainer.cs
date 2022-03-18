
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScriptableSystemsContainer : gameIScriptableSystemsContainer
	{
		public gameScriptableSystemsContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
