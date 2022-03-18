
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIItemFactorySystem : gameIGameSystem
	{
		public gameIItemFactorySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
