
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIScriptableSystemsContainer : gameIGameSystem
	{
		public gameIScriptableSystemsContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
