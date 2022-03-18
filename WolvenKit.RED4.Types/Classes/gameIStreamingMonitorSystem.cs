
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIStreamingMonitorSystem : gameIGameSystem
	{
		public gameIStreamingMonitorSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
