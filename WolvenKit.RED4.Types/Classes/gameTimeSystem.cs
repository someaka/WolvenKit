
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTimeSystem : gameITimeSystem
	{
		public gameTimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
