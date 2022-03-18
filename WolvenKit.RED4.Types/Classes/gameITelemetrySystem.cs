
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameITelemetrySystem : gameIGameSystem
	{
		public gameITelemetrySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
