
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeExecutor_ModifyStat : gameEffectExecutor_Scripted
	{
		public StrikeExecutor_ModifyStat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
