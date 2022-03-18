
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SnapToTargetExecutor : gameEffectExecutor_Scripted
	{
		public SnapToTargetExecutor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
