
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleePreAttackExecutor : gameEffectExecutor_Scripted
	{
		public MeleePreAttackExecutor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
