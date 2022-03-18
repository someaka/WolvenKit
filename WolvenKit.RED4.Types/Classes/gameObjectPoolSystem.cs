
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameObjectPoolSystem : gameIObjectPoolSystem
	{
		public gameObjectPoolSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
