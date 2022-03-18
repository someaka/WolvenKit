
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickMeleeHitExecutor : gameEffectExecutor_Scripted
	{
		public QuickMeleeHitExecutor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
