
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIEffectorSystem : gameIGameSystem
	{
		public gameIEffectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
