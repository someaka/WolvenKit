
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectPostAction_BulletTrace : gameEffectPostAction_BeamVFX
	{
		public gameEffectPostAction_BulletTrace()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
