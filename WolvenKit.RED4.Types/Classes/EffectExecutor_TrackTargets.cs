
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EffectExecutor_TrackTargets : gameEffectExecutor_Scripted
	{
		public EffectExecutor_TrackTargets()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
