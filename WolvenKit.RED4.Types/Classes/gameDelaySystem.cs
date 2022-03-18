
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelaySystem : gameIDelaySystem
	{
		public gameDelaySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
