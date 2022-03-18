
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelayedTimer : gameBaseTimer
	{
		public gameDelayedTimer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
