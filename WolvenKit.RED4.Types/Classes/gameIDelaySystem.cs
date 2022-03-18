
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIDelaySystem : gameIGameSystem
	{
		public gameIDelaySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
