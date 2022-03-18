
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EMPExplosion : gameEffectExecutor_Scripted
	{
		public EMPExplosion()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
