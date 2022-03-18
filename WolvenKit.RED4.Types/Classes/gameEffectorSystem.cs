
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectorSystem : gameIEffectorSystem
	{
		public gameEffectorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
