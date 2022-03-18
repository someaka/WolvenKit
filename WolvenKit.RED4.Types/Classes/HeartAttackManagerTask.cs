
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HeartAttackManagerTask : StatusEffectTasks
	{
		public HeartAttackManagerTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
