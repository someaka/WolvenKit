
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIEntityStubSystem : gameIGameSystem
	{
		public gameIEntityStubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
