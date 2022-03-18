
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityStubSystem : gameIEntityStubSystem
	{
		public gameEntityStubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
