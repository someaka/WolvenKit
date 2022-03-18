
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlindManagerTask : StatusEffectTasks
	{
		public BlindManagerTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
