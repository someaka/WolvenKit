
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIOnlineSystem : gameIGameSystem
	{
		public gameIOnlineSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
