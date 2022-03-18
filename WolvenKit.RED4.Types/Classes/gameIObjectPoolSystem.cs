
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIObjectPoolSystem : gameIGameSystem
	{
		public gameIObjectPoolSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
