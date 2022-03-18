
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netIIngameProfilerSystem : gameIGameSystem
	{
		public netIIngameProfilerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
