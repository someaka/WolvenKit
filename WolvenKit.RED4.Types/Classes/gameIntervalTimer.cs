
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameIntervalTimer : gameBaseTimer
	{
		public gameIntervalTimer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
