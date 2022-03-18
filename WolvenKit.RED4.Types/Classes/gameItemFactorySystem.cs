
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemFactorySystem : gameIItemFactorySystem
	{
		public gameItemFactorySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
