
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnconsciousManagerTask : StatusEffectTasks
	{
		public UnconsciousManagerTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
